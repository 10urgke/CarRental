// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id).UseIdentityColumn();
        builder.Property(x=>x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Stock).IsRequired();
        builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)"); //Benim price değerim 12 haneli olacak toplamda virgülden sonra sadece 2 hane olacak virgülden önce ise 16 hane olacak.
        //################,##
        builder.ToTable("Products"); //Parantez içi boş olursa default olarak classın ismini yani Product verir.
        
    }
}