using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class XPagosLegacy
{
    public int IdLegacy { get; set; }

    public int? Socio { get; set; }

    public int? IdSocioRef { get; set; }

    public int? IdPlanRef { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Tipo { get; set; }

    public string? NombreTipo { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaPago { get; set; }

    public DateTime? FechaPagada { get; set; }

    public bool? MandarAPagar { get; set; }

    public bool? ComisionPagada { get; set; }

    public string? Referencia { get; set; }

    public string? Observaciones { get; set; }

    public string? WalletEmisor { get; set; }

    public string? WalletReceptor { get; set; }
}
