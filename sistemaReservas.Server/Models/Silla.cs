using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaReservas.Server.Models
{
    public class Silla
    {
        [Key]
        public Guid IdSilla { get; set; }

        [ForeignKey("Mesa")]
        public Guid IdMesa { get; set; }    

        [Required(ErrorMessage = "Se debe indicar el tipo de silla")]
        public TipoSilla Tipo { get; set; }

    }
}
