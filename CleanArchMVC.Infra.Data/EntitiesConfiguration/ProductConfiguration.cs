using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.id);
            builder.Property(t => t.name).HasMaxLength(100).IsRequired();
            builder.Property(t => t.description).HasMaxLength(200).IsRequired();
            builder.Property(t => t.price).HasPrecision(10,2);
            builder.HasOne(t => t.category).WithMany(t => t.products).HasForeignKey(t => t.categoryId);
        }
    }
}
