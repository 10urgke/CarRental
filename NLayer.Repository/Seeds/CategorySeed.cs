// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class CategorySeed: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    { 
        builder.HasData(
            new Category {Id = 1, Name = "Arabalar"}, 
            new Category{Id = 2, Name = "Motorlar"}, 
            new Category{Id = 3, Name = "Yatlar"});
    }
}