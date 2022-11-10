namespace Lamorenita.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoProductoId { get; set; }
        public string TipoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Activo { get; set; }
        

    }

    public class ProductCreateModel
    {

        public string Nombre { get; set; }
        public int TipoProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }

    }
}
