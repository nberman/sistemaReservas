using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Entrada
    {
        [Key]
        public int EntradaId { get; set;}

        [Required(ErrorMessage = "Se debe seleccionar un evento")]
        public Evento Evento { get; set; }
        
        //[ForeignKey("Mesa")]
        //[Column(Order = 2)]
        [Required(ErrorMessage = "Se debe seleccionar una mesa")]
        public Mesa Mesa { get; set; }

        //[ForeignKey("Silla")]
        //[Column(Order = 3)]
        [Required(ErrorMessage = "Se debe seleccionar una silla")]
        public Silla Silla { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        public decimal Precio { get; set; } 

    }
}
