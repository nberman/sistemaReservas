using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace sistemaReservas.Server.Models
{
    public class TipoMesa
    {
        [Key]
        public int IdTipoMesa { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar el nombre de la categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Se debe indicar un precio mayor a $0")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Se debe indicar un color")]
        public string Color { get; set; }

    }
}

