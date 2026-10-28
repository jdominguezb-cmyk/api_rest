using System;
using System.Collections.Generic;

namespace api_rest.Models;

public partial class Puesto
{
    public int IdPuesto { get; set; }

    public string Puesto1 { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
