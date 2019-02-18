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
            services.AddDataAccess<VicmaherContext>();

            // Configure Swagger UI
            ConfigureSwagger(services);

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
            var connection = BuildConnectionString(services);
            services.AddDbContext<VicmaherContext>(options => options.UseSqlServer(connection.ToString()));
        }

        private void ConfigureSwagger(IServiceCollection services)
        {

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
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(options =>
            {
                var swaggerJsonBasePath = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";

                options.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/{_swaggerVersion}/swagger.json", $"Integrations services API {_swaggerVersion}");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
