using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sistemaReservas.Server.Models
{
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; }  
        
        [Required(ErrorMessage = "Se debe indicar un nombre para el evento")]
        public string Nombre { get; set; }  
        
        [Required(ErrorMessage = "Se debe indicar una fecha para el evento")]
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "Se deben agregar las mesas al evento")]
        public ICollection<Mesa> Mesas { get; set; }
            


    }
}
