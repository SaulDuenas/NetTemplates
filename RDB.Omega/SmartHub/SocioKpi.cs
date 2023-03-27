using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla concentradora de las metricas de los socios
/// 
/// Esta tabla se actualizará en línea cada que:
/// 1) se integra un nuevo socio
/// 2) se efectua la compra de un plan adicional
/// 3) se hace algún retiro
/// 
/// 
/// </summary>
public partial class SocioKpi
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// ID del rango
    /// </summary>
    public int? Rango { get; set; }

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
    /// folio del cambio de rango más reciente (socio_kpi_hist.folio)
    /// </summary>
    public int? UltimoCambio { get; set; }

    /// <summary>
    /// bandera para identificar si el socio tiene beneficios (ver notas)
    /// </summary>
    public short? ConBeneficios { get; set; }

    /// <summary>
    /// Fecha en la que inicia el goce de beneficios
    /// </summary>
    public DateTime? FechaIniBeneficios { get; set; }

    /// <summary>
    /// Periodo de cálculo de bonos 1=primera quincena, 2=segunda quincena
    /// </summary>
    public int? Periodo { get; set; }

    /// <summary>
    /// Fecha en que cambió de rango
    /// </summary>
    public DateTime? FechaRango { get; set; }

    /// <summary>
    /// próxima fecha de pago de bono mensual
    /// </summary>
    public DateOnly? FechaPago { get; set; }

    /// <summary>
    /// ID del rango del pago que se realizará
    /// </summary>
    public int? RangoPago { get; set; }

    public short? CorreoEnviado { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public bool Etl { get; set; }

    public bool Ejecutivo { get; set; }

    public int? Procesado { get; set; }

    public decimal? SaldoOrganizacionV2 { get; set; }

    public int Estrellas { get; set; }

    public decimal SaldoEstrellas { get; set; }

    public int AlgoritmoRangos { get; set; }

    public int? RangoV2 { get; set; }

    /// <summary>
    /// ref folio  tabla socio_kpi_hist
    /// </summary>
    public int? FolioHist { get; set; }

    public virtual Rango? RangoNavigation { get; set; }

    public virtual Rango? RangoPagoNavigation { get; set; }

    public virtual ICollection<SocioKpiHistBorrar> SocioKpiHistBorrars { get; } = new List<SocioKpiHistBorrar>();

    public virtual ICollection<SocioKpiHist> SocioKpiHists { get; } = new List<SocioKpiHist>();
}
