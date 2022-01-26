using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace sistemaReservas.Server.Models
{
    public class TipoMesa
    {
        [Key]
        public int IdTipoMesa { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar el tipo de silla")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Se debe indicar un color")]
        public KnownColor Color { get; set; }

    }
}

