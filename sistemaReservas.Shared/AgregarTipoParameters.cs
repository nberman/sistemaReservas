using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace sistemaReservas.Shared
{
    public class AgregarTipoParameters
    {
        [Required(ErrorMessage = "Se debe indicar el nombre de la categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar un color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Se debe indicar el precio")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Se debe indicar un precio mayor a $0")]
        public decimal Precio { get; set; }
    }
}
