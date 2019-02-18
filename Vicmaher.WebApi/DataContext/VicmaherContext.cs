using Microsoft.EntityFrameworkCore;
using Platform.DAL.DataContext;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebServices.DataContext
{
    public class VicmaherContext : EntityContextBase<VicmaherContext>
    {
        public VicmaherContext(DbContextOptions<VicmaherContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Joke> Jokes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
