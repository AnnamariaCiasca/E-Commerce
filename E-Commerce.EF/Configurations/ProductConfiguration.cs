using E_Commerce.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EF.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Code)
                          .IsRequired()
                          .HasMaxLength(5);

            builder.Property(e => e.Description)
              .IsRequired()
              .HasMaxLength(200);

            builder.Property(e => e.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (ProductType)Enum.Parse(typeof(ProductType), v));

            builder.Property(e => e.Price);
            builder.Property(e => e.SupplierPrice);

            builder.HasData(new Product
            {
                Id = 1,
                Code = "00001",
                Price = 750,
                Type = ProductType.Electronic,
                SupplierPrice = 500,
                Description = "Smart Tv Sony 65 inches"
            });
        }
    }
}
