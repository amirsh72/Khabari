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
    public class NewsCategoryMapping : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.ToTable("NewsCategory");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c=>c.Description).HasMaxLength(1000);

            builder.HasMany(c=>c.OneNews).WithOne(c=>c.NewsCategory).HasForeignKey(c=>c.NewsCategoryId);
        }
    }
}
