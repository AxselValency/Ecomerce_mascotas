using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.DTO
{
    public class TrakingPedidoDTO
    {

        public int IdSeguimiento { get; set; }
        public int IdVenta { get; set; }
        public int IdEstado { get; set; }
        public string? Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
