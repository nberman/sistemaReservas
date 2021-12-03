using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Mesa
    {
        [Key]
        public Guid IdMesa { get; set; }

        [ForeignKey("Evento")]
        public Guid IdEvento { get; set; } 

        [Required(ErrorMessage = "Se debe indicar el número de mesa")]
        public int NumeroMesa { get; set; }

        [Required(ErrorMessage = "Se deben agregar las sillas a la mesa")]
        public ICollection<Silla> Sillas { get; set; }
    }
}
