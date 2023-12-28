using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServicesManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesManagement.Infrastructure.Mapping
{
    public class ServiceCategoryMapping : IEntityTypeConfiguration<ServicCategory>
    {
        public void Configure(EntityTypeBuilder<ServicCategory> builder)
        {
            builder.ToTable("ServiceCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x=>x.Description).HasMaxLength(1000);

            builder.HasMany(x=>x.services).WithOne(x=>x.ServiceCategory).HasForeignKey(x=>x.ServiceCategoryId);

        }
    }
}
