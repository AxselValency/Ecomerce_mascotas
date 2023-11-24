using System;
using System.Collections.Generic;

namespace Ecomerce.Modelo;

public partial class ComentarioPedido
{
    public int IdComentario { get; set; }

    public int? IdVenta { get; set; }

    public string? Comentario { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }
}
