using CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStore.SQL.Context.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Products)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId);

            builder.HasData(
                    new Category { CategoryId = 1, Name = "Bebida", Description = "Bebida" },
                    new Category { CategoryId = 2, Name = "Panaderia", Description = "Panaderia" },
                    new Category { CategoryId = 3, Name = "Carne", Description = "Carne" }
                );
        }
    }
}
