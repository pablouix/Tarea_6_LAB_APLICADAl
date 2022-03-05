

using System.ComponentModel.DataAnnotations;

namespace Tarea_6.Entidades
{
    public partial class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; } 
        public string? Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public ProductosDetalle(string descripcion, int cantidad, double precio)
        {
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
        }

        public  ProductosDetalle()
        {

        }
    }
}