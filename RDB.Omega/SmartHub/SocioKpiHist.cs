using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Histórico de cambios de rango de los socios
/// 
/// Cada que ocurre un cambio de rango en un socio se guarda un registro en esta tabla, de tal modo que, el registro más reciente contiene los kpi actuales vigentes del socio (una copia de socio_kpi)
/// 
/// </summary>
public partial class SocioKpiHist
{
    /// <summary>
    /// folio autonumérico del registro
    /// </summary>
    public long Folio { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Total de saldo acumulado por planes de su red (Cantidad de Saldo de la organización del socio)
    /// </summary>
    public decimal? SaldoOrganizacion { get; set; }

    /// <summary>
    /// Total de saldo personal por planes adicionales (Cantidad de Saldo personal de planes adicionales por socio)
    /// 
    /// </summary>
    public decimal? SaldoPersonal { get; set; }

    /// <summary>
    /// Total de Frontales ó afiliados directos (cantidad de socios directos del socio)
    /// </summary>
    public int? Directos { get; set; }

    /// <summary>
    /// Total de Frontales ó afiliados directos con planes  adicionales (cantidad de socios directos con plan adicional)
    /// </summary>
    public int? DirectosPlan { get; set; }

    /// <summary>
    /// Total de descendientes (contando todos sus hijos, nietos, bisnietos, etc)
    /// </summary>
    public int? Descendientes { get; set; }

    /// <summary>
    /// Indica si cambió de rango 0=Sin Cambio, 1=Subió, 2=Bajó
    /// </summary>
    public int? CambioRango { get; set; }

    /// <summary>
    /// bandera para identificar si el socio tiene beneficios
    /// </summary>
    public short? ConBeneficios { get; set; }

    /// <summary>
    /// Periodo de cálculo de bonos 1=primera quincena, 2=segunda quincena
    /// </summary>
    public int? Periodo { get; set; }

    /// <summary>
    /// Fecha en que ocurrió el cambio de rango
    /// </summary>
    public DateTime? FechaRango { get; set; }

    /// <summary>
    /// próxima fecha de pago de bono mensual
    /// </summary>
    public DateOnly? FechaPago { get; set; }

    public short? CorreoEnviado { get; set; }

    public DateTime FechaInsert { get; set; }

    public bool Etl { get; set; }

    public int? Rango { get; set; }

    public int? RangoPago { get; set; }

    public virtual SocioKpi SocioNavigation { get; set; } = null!;
}
