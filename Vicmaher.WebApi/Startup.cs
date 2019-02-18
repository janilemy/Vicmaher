using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Platform.DAL.Options;
using Platform.DAL.Startup;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Reflection;
using Vicmaher.WebApi.Services;
using Vicmaher.WebApi.Services.Interfaces;
using Vicmaher.WebServices.DataContext;

namespace Vicmaher.WebServices
{
    /// <summary>
    /// Startup class.
    /// </summary>
    public class Startup
    {
        private readonly ILogger<Startup> _logger;
        private const string _swaggerVersion = "v1";

        /// <summary>
        ///   Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="configuration">
        ///   The configuration.
        /// </param>
        /// <param name="logger">
        ///   The logger.
        /// </param>
        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
            _logger = logger;
        }

        /// <summary>
        ///   Gets the configuration.
        /// </summary>
        /// <value>
        ///   The configuration.
        /// </value>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure dataAccess service
            ConfigureDatabase(services);

            // Configure Swagger UI
            // ConfigureSwagger(services);

            services.AddScoped<IJokeService, JokeService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddCors(options => options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithOrigins("http://localhost:64148")
                        .WithOrigins("https://localhost:44326")
                        .AllowCredentials();
                }));

            // Add framework service
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private ConnectionString BuildConnectionString(IServiceCollection services)
        {
            var section = Configuration.GetSection("ConnectionString");
            services.Configure<ConnectionString>(section);

            var configureOptions = services.BuildServiceProvider().GetRequiredService<IConfigureOptions<ConnectionString>>();
            var connectionString = new ConnectionString();
            configureOptions.Configure(connectionString);
            return connectionString;
        }

        private void ConfigureDatabase(IServiceCollection services)
        {
            //var connection = BuildConnectionString(services);
            var connection = @"Server=localhost;Database=Vicmaher;Trusted_Connection=True;";
            services.AddDbContext<VicmaherContext>(options => options.UseSqlServer(connection));
            services.AddDataAccess<VicmaherContext>();
        }

        private void ConfigureSwagger(IServiceCollection services)
        {
            string docFile = Path.ChangeExtension(Assembly.GetEntryAssembly().Location, "xml");
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(_swaggerVersion,
                    new Info
                    {
                        Title = "Vicmaher API",
                        Version = typeof(Startup).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version
                    });
                options.DocInclusionPredicate((docName, description) => true);
                options.DescribeAllEnumsAsStrings();

                if (File.Exists(docFile))
                {
                    options.IncludeXmlComments(Path.Combine(docFile));
                }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            // app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            //app.UseSwaggerUI(options =>
            //{
            //    var swaggerJsonBasePath = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";
            //    options.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/{_swaggerVersion}/swagger.json", $"Vicmaher WebApi {_swaggerVersion}");
            //});

            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
