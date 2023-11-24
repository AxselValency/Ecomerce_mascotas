using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.DTO
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "Ingerse Correo")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Ingerse nombre Contraseña")]
        public string? Clave { get; set; }


    }
}
