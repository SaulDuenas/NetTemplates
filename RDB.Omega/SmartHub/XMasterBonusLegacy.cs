using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class XMasterBonusLegacy
{
    public DateOnly FechaPago { get; set; }

    public int Socio { get; set; }

    public int? Rango { get; set; }

    public DateOnly? FechaRango { get; set; }

    public decimal? Monto { get; set; }

    public int? Aaaa { get; set; }

    public int? Mm { get; set; }

    public int? Dd { get; set; }

    public int? Periodo { get; set; }

    public int? Status { get; set; }

    public string? Observaciones { get; set; }

    public string? IdRef { get; set; }

    public DateTime? FechaReg { get; set; }
}
