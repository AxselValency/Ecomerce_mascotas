using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.DTO
{
    public class CategoriaDTO
    {



        public int IdCategoria { get; set; }


        [Required(ErrorMessage = "Ingerse nombre")]
        public string? Nombre { get; set; }


    }
}
