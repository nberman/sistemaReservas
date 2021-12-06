using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaReservas.Shared
{
    public class AgregarEventoParameters
    {
        [Required(ErrorMessage = "Se debe indicar el nombre del evento")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe indicar la fecha del evento")]
        public DateTime? Fecha { get; set; } = null;

    }
}
