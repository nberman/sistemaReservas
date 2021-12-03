using System;
using System.ComponentModel.DataAnnotations;

namespace sistemaReservas.Server.Models
{
    public class TipoSilla
    {
        [Key]
        public Guid IdTipoSilla { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar el tipo de silla")]
        public Enum Tipo { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        public decimal Precio { get; set; }
    }
}

public enum Tipo
{
    Gold,
    Silver,
    VIP
}
