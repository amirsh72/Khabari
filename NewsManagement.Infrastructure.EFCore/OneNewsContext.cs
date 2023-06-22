using Microsoft.EntityFrameworkCore;
using NewsManagement.Domain;
using NewsManagement.Infrastructure.EFCore.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Infrastructure.EFCore
{
    public class OneNewsContext:DbContext
    {

        public OneNewsContext()
        {

        }
        public OneNewsContext(DbContextOptions<OneNewsContext> options) : base(options)
        {

        }

       

        public DbSet<OneNews> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var assembly = typeof(OneNewsMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
