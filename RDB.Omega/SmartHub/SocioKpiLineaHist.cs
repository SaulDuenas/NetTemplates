using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class SocioKpiLineaHist
{
    /// <summary>
    /// folio autonumérico del registro
    /// </summary>
    public int Folio { get; set; }

    public int NumLinea { get; set; }

    public int RangoReq { get; set; }

    public string RangoReqText { get; set; } = null!;

    public int Cantidad { get; set; }

    public int? IdSocio { get; set; }

    public string? Socio { get; set; }

    public int? Rango { get; set; }

    public string? RangoText { get; set; }

    public int? Nivel { get; set; }

    public int? Linea { get; set; }

    public DateTime? FechaRango { get; set; }
}
