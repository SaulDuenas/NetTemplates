using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class SocioKpiTest
{
    public int Socio { get; set; }

    public int? Rango { get; set; }

    public decimal? SaldoOrganizacion { get; set; }

    public decimal? SaldoPersonal { get; set; }

    public int? Directos { get; set; }

    public int? DirectosPlan { get; set; }

    public int? Descendientes { get; set; }

    public int? CambioRango { get; set; }

    public int? UltimoCambio { get; set; }

    public short? ConBeneficios { get; set; }

    public DateTime? FechaIniBeneficios { get; set; }

    public int? Periodo { get; set; }

    public DateTime? FechaRango { get; set; }

    public DateOnly? FechaPago { get; set; }

    public int? RangoPago { get; set; }

    public short? CorreoEnviado { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public bool Etl { get; set; }

    public bool Ejecutivo { get; set; }

    public int? RangoTest { get; set; }

    public DateTime? FechaRangoTest { get; set; }

    public int? CambioRangoTest { get; set; }

    public int? PeriodoTest { get; set; }

    public int? ConBeneficiosTest { get; set; }

    public DateTime? FechaIniBeneficiosTest { get; set; }
}
