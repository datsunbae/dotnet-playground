using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }

    }
}
