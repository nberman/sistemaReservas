using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaReservas.Shared
{
    public class AgregarMesaParameters
    {
        [Required(ErrorMessage = "Se debe indicar el evento")]
        public int? Evento { get; set; }        

        [Required(ErrorMessage = "Se debe indicar el número de mesa.")]
        public int NumeroMesa { get; set; }

        [Required(ErrorMessage = "Se debe indicar la cantidad de sillas.")]
        public int CantidadSillas { get; set; }

        [Required(ErrorMessage = "Se debe indicar la categoría de la mesa.")]
        public int? Categoria { get; set; }

        public List<int> Sillas { get; set; } = new List<int>();   

    }
}
