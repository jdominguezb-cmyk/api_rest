using System;
using System.Collections.Generic;
using System.Text.Json.Serialization; 

namespace api_rest.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nit { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Email { get; set; }

    [JsonIgnore] 
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}