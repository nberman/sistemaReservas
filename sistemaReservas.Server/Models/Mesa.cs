using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Mesa
    {
        [Key]
        public int IdMesa { get; set; }

        public Evento Evento { get; set; } 

        [Required(ErrorMessage = "Se debe indicar el número de mesa")]
        public int NumeroMesa { get; set; }

        [Required(ErrorMessage = "Se debe indicar la categoría de la mesa")]
        public TipoMesa? Categoria { get; set; }

        [Required(ErrorMessage = "Se deben agregar las sillas a la mesa")]
        public List<Silla>? Sillas { get; set; }
    }
}
