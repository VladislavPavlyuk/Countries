using Microsoft.EntityFrameworkCore;

namespace Countries
{
    public class CountryContext : DbContext
    {
        public CountryContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // метод UseLazyLoadingProxies() делает доступной ленивую загрузку.
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=DESKTOP-A3O7OP4;Database=CountriesDB;Integrated Security=SSPI;TrustServerCertificate=true");
        }
    }
}
