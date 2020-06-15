using DemoArch.Repository.DataSeeding;
using Microsoft.EntityFrameworkCore;

namespace DemoArch.Repository.Entities
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }


        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
