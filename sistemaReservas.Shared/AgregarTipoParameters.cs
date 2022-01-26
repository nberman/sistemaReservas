using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace sistemaReservas.Shared
{
    internal class AgregarTipoParameters
    {
        [Required(ErrorMessage = "Se debe indicar el nombre de la categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar un color")]
        public KnownColor Color { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        public decimal Precio { get; set; }
    }
}
