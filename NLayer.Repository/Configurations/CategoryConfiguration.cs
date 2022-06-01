using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id); //Key'i Id olarak belirler.
        builder.Property(x => x.Id).UseIdentityColumn(); //Id sütununu kullan Idyi default olarak 1-1 arttır.
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50); // IsRequired= zorunlu olsun ve max karakter 50 olsun.
        builder.Property(x => x.CreatedDate).HasColumnType("timestamp with time zone");
        builder.Property(x => x.UpdatedDate).HasColumnType("timestamp with time zone'");

        builder.ToTable("Categories");
    }
}