using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Infrastructure.EFCore.Mapping
{
    public class OneNewsMapping : IEntityTypeConfiguration<OneNews>
    {
        public void Configure(EntityTypeBuilder<OneNews> builder)
        {
            builder.ToTable("News");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Subject).HasMaxLength(50);
            builder.Property(x=>x.Body).HasMaxLength(5000);
            builder.Property(x => x.Tag).HasMaxLength(100);
        }
    }
}
