// ReSharper disable All
namespace NLayer.Core;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; } //ForeignKey vermeden bu şekilde kullanabiliriz çünkü EFCore bunu algılar Idnin kategori ıdsi olduğunu.
    public Category Category { get; set; } //Navigation Property Producttan Categorye gidebiliriz.
    public ProductFeature ProductFeature { get; set; } //Navigation Property Producttan ProductFeaturea gidebiliriz. ALTININ SARI ÇİZGİ OLMASININ SEBEBİ NULL OLABİLİYOR OLMASI!!!
    
    //EF Core buradaki adlandırmaları foreign key olarak algıladığı için ileride ProductConfigurations.csde özel olarak tanımlamaya gerek kalmıyor!!!!
    
}