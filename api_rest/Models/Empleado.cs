using System;
using System.Collections.Generic;

namespace api_rest.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public int IdPuesto { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Puesto IdPuestoNavigation { get; set; } = null!;
}
