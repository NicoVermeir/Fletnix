﻿using Fletnix.Model;
using Microsoft.EntityFrameworkCore;

namespace Fletnix.Api.Repositories
{
    public class FletnixContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Fletnix.Db;"); Groep2 constring
            optionsBuilder.UseSqlServer(@"Server=.;Database=Fletnix.Db;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
