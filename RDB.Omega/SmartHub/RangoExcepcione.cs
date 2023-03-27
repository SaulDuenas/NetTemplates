using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class RangoExcepcione
{
    public int Socio { get; set; }

    public int? Tipo { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }
}
