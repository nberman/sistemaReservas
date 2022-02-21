using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistemaReservas.Shared
{
    public class ListarTipoParameters
    {
        public int IdTipoMesa { get; set; }

        public string Nombre { get; set; }

        public string Color { get; set; }

        public decimal Precio { get; set; }        

    }
}
