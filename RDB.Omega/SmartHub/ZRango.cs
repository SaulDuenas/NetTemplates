using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZRango
{
    public int? Rango { get; set; }

    public string? Nombre { get; set; }

    public string? Alias { get; set; }

    public int? RangoPrev { get; set; }

    public int? RangoNext { get; set; }

    public int? BonoMensual { get; set; }

    public decimal? SaldoPersonalReq { get; set; }

    public decimal? SaldoAcumuladoReq { get; set; }

    public int? NivelesAcumulado { get; set; }

    public int? DirectosReq { get; set; }

    public int? DirectosAdicionalReq { get; set; }

    public int? LineasReq { get; set; }

    public int? Version { get; set; }
}
