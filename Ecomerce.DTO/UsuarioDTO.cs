using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage="Ingrese nombre Completo")]
        public string? NombreCompleto { get; set; }

        [Required(ErrorMessage = "Ingerse Correo")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Ingerse nombre Contraseña")]
        public string? Clave { get; set; }

        [Required(ErrorMessage = "Confirme la Contraseña")]
        public string? ConfirmarClave { get; set; }



        public string? Rol { get; set; }

       

        
    }
}
