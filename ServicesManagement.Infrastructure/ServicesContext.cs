using Microsoft.EntityFrameworkCore;
using ServicesManagement.Domain;
using ServicesManagement.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesManagement.Infrastructure
{
    public class ServicesContext:DbContext
    {
        public ServicesContext() 
        {

        }
        public ServicesContext(DbContextOptions<ServicesContext> options) : base(options) 
        { 

        }

        public DbSet<ServicCategory> ServicesCategories { get; set; }
        public DbSet<Service> services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assemly=typeof(ServiceMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assemly);
            base.OnModelCreating(modelBuilder);
        }




    }
}
