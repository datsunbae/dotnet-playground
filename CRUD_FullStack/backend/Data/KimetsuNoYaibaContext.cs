using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class KimetsuNoYaibaContext : DbContext
    {
        public KimetsuNoYaibaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Character> Characters { get; set; }
    }
}