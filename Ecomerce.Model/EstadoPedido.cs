using System;
using System.Collections.Generic;

namespace Ecomerce.Modelo;

public partial class EstadoPedido
{
    public int IdEstado { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<SeguimientoPedido> SeguimientoPedidos { get; set; } = new List<SeguimientoPedido>();
}
