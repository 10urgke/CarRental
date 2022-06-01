// ReSharper disable All

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;

namespace NLayer.Repository;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //DbContextteki standart bir constructor.
    {
        
    }
    
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Product> Products { get; set; }
    
    public DbSet<ProductFeature> ProductFeatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) //Model oluşurken çalışacak komut.
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Bütün configurationları uygular..
        modelBuilder.Entity<ProductFeature>().HasData(
            new ProductFeature()
            {
                Id = 1,
                Color = "kırmızı",
                Height = 100,
                Width = 200, 
                ProductId = 1
            },
            new ProductFeature()
            {
                Id = 2,
                Color = "sarı",
                Height = 200,
                Width = 400,
                ProductId = 2
            },
            new ProductFeature()
            {
                Id = 3,
                Color = "Mavi",
                Height = 300,
                Width = 600,
                ProductId = 3
            });
        
        base.OnModelCreating(modelBuilder);
    }
}