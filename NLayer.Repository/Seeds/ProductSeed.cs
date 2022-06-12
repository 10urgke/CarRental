// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProductSeed: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product
        {
            Id = 1,
            CategoryId = 1,
            Name = "Audi",
            Price = 100000,
            Stock = 20,
            CreatedDate = DateTime.Now
            
        },
        new Product
        {
            Id = 2,
            CategoryId = 1,
            Name = "Mercedes",
            Price = 200000,
            Stock = 30,
            CreatedDate = DateTime.Now
            
        },
        new Product
        {
            Id = 3,
            CategoryId = 1,
            Name = "BMW",
            Price = 600,
            Stock = 20,
            CreatedDate = DateTime.Now
            
        },
        new Product
        {
            Id = 4,
            CategoryId = 2,
            Name = "Harley Davidson",
            Price = 600,
            Stock = 60,
            CreatedDate = DateTime.Now
            
        },
        new Product
        {
            Id = 5,
            CategoryId = 2,
            Name = "Yamaha",
            Price = 6600,
            Stock = 320,
            CreatedDate = DateTime.Now
            
        },
        new Product
        {
            Id = 6,
            CategoryId = 2,
            Name = "Pulsar",
            Price = 31241,
            Stock = 231,
            CreatedDate = DateTime.Now
        },
        new Product
        {
            Id = 7,
            CategoryId = 3,
            Name = "Stella",
            Price = 31241,
            Stock = 231,
            CreatedDate = DateTime.Now
        });
    }
}