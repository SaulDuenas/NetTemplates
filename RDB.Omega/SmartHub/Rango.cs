using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// catalogo de rangos 
/// </summary>
public partial class Rango
{
    /// <summary>
    /// ID del rango
    /// </summary>
    public int Rango1 { get; set; }

    /// <summary>
    /// nombre del rango
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Alias del rango
    /// </summary>
    public string Alias { get; set; } = null!;

    /// <summary>
    /// Id del rango previo 
    /// </summary>
    public int? RangoPrev { get; set; }

    /// <summary>
    /// Id del rango siguiente
    /// </summary>
    public int? RangoNext { get; set; }

    /// <summary>
    /// bono mensual que gana el socio por estar en este rango
    /// </summary>
    public int? BonoMensual { get; set; }

    /// <summary>
    /// Saldo personal de planes adicionales requerido para el rango
    /// </summary>
    public decimal? SaldoPersonalReq { get; set; }

    /// <summary>
    /// Saldo acumulado de organización requerido para el rango
    /// </summary>
    public decimal? SaldoAcumuladoReq { get; set; }

    /// <summary>
    /// Cuantos niveles de profundidad se consideran para el acumulado de la organización
    /// </summary>
    public int? NivelesAcumulado { get; set; }

    /// <summary>
    /// Cantidad de socios directos (hijos) requeridos para el rango
    /// </summary>
    public int? DirectosReq { get; set; }

    /// <summary>
    /// Cantidad de socios directos con plan adicional requeridos para el rango
    /// </summary>
    public int? DirectosAdicionalReq { get; set; }

    /// <summary>
    /// Lineas requeridas con socios con algún rango (antes estructura_rango)
    /// </summary>
    public int? LineasReq { get; set; }

    public int? Version { get; set; }

    public virtual ICollection<Publicacione> Publicaciones { get; } = new List<Publicacione>();

    public virtual ICollection<RangoReqLinea> RangoReqLineaRangoNavigations { get; } = new List<RangoReqLinea>();

    public virtual ICollection<RangoReqLinea> RangoReqLineaRangoReqNavigations { get; } = new List<RangoReqLinea>();

    public virtual ICollection<SocioKpi> SocioKpiRangoNavigations { get; } = new List<SocioKpi>();

    public virtual ICollection<SocioKpi> SocioKpiRangoPagoNavigations { get; } = new List<SocioKpi>();

    public virtual ICollection<Promocione> Promocions { get; } = new List<Promocione>();
}
