namespace Lamorenita.Data_Entities
{
    public class ProductTypeEntity : CatalogEntity
    {
        public virtual ICollection<ProductEntity>? Product { get; set; }
    }
}
