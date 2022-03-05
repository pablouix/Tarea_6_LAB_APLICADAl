

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea_6.Entidades
{

    //agregar fecha de caduccidad 
    public partial class Productos
    {
        [Key]
        public int ProductoId {get; set;}

        [Required(ErrorMessage = "Campo obligatorio. Se debe indicar la descripción.")]
        [MinLength(3, ErrorMessage ="La descripción debe tener almenos {1} caracteres.")]
        [MaxLength(35, ErrorMessage ="La descripción no debe pasar de {1} caracteres. ")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="Campo obligatorio. poner fecha de vencimiento.")]
        public DateTime FechaDeVencimiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio. Se debe indicar la existencia.")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe indicar la existencia del producto dentro de los tangos {1}/{2}")]
        public int Existencia { get; set; }

        [Required(ErrorMessage ="El campo \"Costo\" está vacío. Por favor indique un costo.")]
        //[Range(1, int.MaxValue, ErrorMessage = "El costo debe estar dentro del rango permitido {1}/{2}.")]
        public double Costo { get; set; }
        public double ValorInventario {get; set;}

        [Required(ErrorMessage ="Campo obligatorio. Se debe indicar el precio.")]
       // [Range(1, int.MaxValue, ErrorMessage = "Se debe indicar el precio del producto dentro de los rangos {1}/{2}")]
        public double Precio { get; set; }
        [Range(1, 100, ErrorMessage ="La ganancia debe de estar entre 1 y 100")]
        public int Ganancia {get; set;}

        [ForeignKey("ProductoId")]
        public virtual List<ProductosDetalle> ProductosDetalle {get; set;} = new List<ProductosDetalle>();

    }
}