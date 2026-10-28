using System;
using System.Collections.Generic;

namespace api_rest.Models;

public partial class DetalleFactura
{
    public int IdDetalleFactura { get; set; }

    public int IdFactura { get; set; }

    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioCostoUnitario { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
