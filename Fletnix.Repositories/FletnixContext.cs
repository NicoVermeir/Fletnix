using Fletnix.Model;
using Microsoft.EntityFrameworkCore;

namespace Fletnix.Repositories
{
    public class FletnixContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=Fletnix.Db;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SVE1DI5\YANNSTUDIO_01;Database=Fletnix.Db;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
