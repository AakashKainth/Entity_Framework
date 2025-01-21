using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    public class EfDemoDbContext : DbContext
    {
        private readonly string _connString;
        public DbSet<Product> Products { get; set; }

        public EfDemoDbContext(string connString)
        {
            _connString = connString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connString);
            }
        }
    }
}
