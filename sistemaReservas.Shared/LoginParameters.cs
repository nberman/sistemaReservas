using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sistemaReservas.Shared
{
    public class LoginParameters
    {
        [Required(ErrorMessage = "El campo usuario es requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo contraseña es requerido")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
