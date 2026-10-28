using System;
using System.Collections.Generic;

namespace api_rest.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public int NoFactura { get; set; }

    public string Serie { get; set; } = null!;

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public DateTime? FechaFactura { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
}
