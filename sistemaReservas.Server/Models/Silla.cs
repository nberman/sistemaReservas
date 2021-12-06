using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Silla
    {
        [Key]
        public int IdSilla { get; set; }

        public Mesa? Mesa { get; set; }

        [Required(ErrorMessage = "Se debe indicar el tipo de silla")]
        public TipoSilla Tipo { get; set; }
        
    }
}
