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
    public class ServiceMapping : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).HasMaxLength(50);
            builder.Property(x=>x.Body).HasMaxLength(500);
            builder.Property(x => x.Tag).HasMaxLength(50);

            builder.HasOne(x => x.ServiceCategory)
                .WithMany(x => x.services)
                .HasForeignKey(x => x.ServiceCategoryId);
        }
    }
}
