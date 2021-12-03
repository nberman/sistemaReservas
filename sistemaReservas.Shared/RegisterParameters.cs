using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sistemaReservas.Shared
{
    public class RegisterParameters
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
        public string PasswordConfirm { get; set; }
    }
}
