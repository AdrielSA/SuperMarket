using CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataStore.SQL.Context.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "Refresco", Quantity = 200, Price = 84.99 },
                    new Product { ProductId = 2, CategoryId = 1, Name = "Jugo", Quantity = 150, Price = 14.99 },
                    new Product { ProductId = 3, CategoryId = 2, Name = "Pan integral", Quantity = 50, Price = 79.99 },
                    new Product { ProductId = 4, CategoryId = 2, Name = "Pan de mantequilla", Quantity = 75, Price = 79.99 },
                    new Product { ProductId = 5, CategoryId = 3, Name = "Carne de res", Quantity = 15, Price = 314.99 },
                    new Product { ProductId = 6, CategoryId = 3, Name = "Carne de pollo", Quantity = 35, Price = 209.99 }
                );
        }
    }
}
