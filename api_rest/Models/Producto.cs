using System;
using System.Collections.Generic;

namespace api_rest.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Producto1 { get; set; } = null!;

    public int IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public decimal? PrecioCosto { get; set; }

    public decimal? PrecioVenta { get; set; }

    public int? Existencia { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Marca IdMarcaNavigation { get; set; } = null!;
}
