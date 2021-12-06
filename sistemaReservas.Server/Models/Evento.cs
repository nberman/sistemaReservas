using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }  
        
        [Required(ErrorMessage = "Se debe indicar un nombre para el evento")]
        public string Nombre { get; set; }  
        
        [Required(ErrorMessage = "Se debe indicar una fecha para el evento")]
        public DateTime Fecha { get; set; }
        
        public ICollection<Mesa>? Mesas { get; set; }

        public int? CantidadSillasTotal { get; set; }

        public int? CantidadSillasVendidas { get; set; }

        [NotMapped]
        public float? Ocupacion
        {
            get
            {
                if (CantidadSillasVendidas != null && CantidadSillasTotal != null)
                {
                    int? v = (CantidadSillasVendidas / CantidadSillasTotal);
                    return (float)v;
                }
                return null;
            }
        }
            


    }
}
