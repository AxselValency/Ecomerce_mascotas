﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.DTO
{
    public class TarjetaDTO
    {

        [Required(ErrorMessage = "Ingrese Nombre Titular ")]
        public string? Titular { get; set; }

        [Required(ErrorMessage = "Ingrese Numero de la Tarjeta")]
        public string? Numero { get; set; }

        [Required(ErrorMessage = "Ingrese Vigencia")]
        public string? Vigencia { get; set; }

        [Required(ErrorMessage = "Ingrese CVV")]
        public string? CVV { get; set;}




    }
}
