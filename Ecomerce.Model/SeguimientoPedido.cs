using System;
using System.Collections.Generic;

namespace Ecomerce.Modelo;

public partial class SeguimientoPedido
{
    public int IdSeguimiento { get; set; }

    public int? IdVenta { get; set; }

    public int? IdEstado { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual EstadoPedido? IdEstadoNavigation { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }
}
