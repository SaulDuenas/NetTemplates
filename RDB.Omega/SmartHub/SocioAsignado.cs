using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class SocioAsignado
{
    public int Socio { get; set; }

    public string? Email { get; set; }

    public int? Padre { get; set; }

    public int? AsignadoA { get; set; }

    public DateTime? Fecha { get; set; }
}
