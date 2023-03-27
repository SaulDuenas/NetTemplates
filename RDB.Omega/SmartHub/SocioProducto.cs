using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// 
/// 
/// (depositos_inversion)
/// </summary>
public partial class SocioProducto
{
    /// <summary>
    /// id del plan
    /// </summary>
    public int Plan { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// Folio autonumérico de la compra o intención de compra
    /// </summary>
    public int Compra { get; set; }

    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int? Promocion { get; set; }

    /// <summary>
    /// Indica si el plan puede tener retiros y rendimientos 
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// Indica si el producto está cerrado (se retiró todo o casi todo el dinero)
    /// </summary>
    public bool Cerrado { get; set; }

    /// <summary>
    /// Capital inicial de la inversión
    /// </summary>
    public decimal CapitalInicial { get; set; }

    /// <summary>
    /// Moneda (Enum Monedas [sValor])
    /// </summary>
    public string Moneda { get; set; } = null!;

    /// <summary>
    /// Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)
    /// </summary>
    public decimal RendimientoInicial { get; set; }

    /// <summary>
    /// Viene de microcatálogo (ReglasCapitalizacion) 1=Mensual, 2=Quincenal
    /// </summary>
    public int ReglaCapitalizacion { get; set; }

    /// <summary>
    /// plazo mínimo forzoso en meses donde No se puede retirar (normalmente 24 en membresías y 0 en planes adicionales)
    /// </summary>
    public int PlazoForzoso { get; set; }

    /// <summary>
    /// duración en meses del plazo mínimo para no causar comisiones al retirar 
    /// </summary>
    public int PlazoComision { get; set; }

    /// <summary>
    /// duración nominal del producto en meses (normalmente 24 meses) 0=Eterno
    /// </summary>
    public int Duracion { get; set; }

    /// <summary>
    /// Capital inicial de la inversión (puede ser afectado por un retiro)
    /// </summary>
    public decimal Capital { get; set; }

    /// <summary>
    /// Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2) PUEDE VARIAR CON LOS RETIROS
    /// </summary>
    public decimal Rendimiento { get; set; }

    /// <summary>
    /// porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)
    /// </summary>
    public decimal Comision { get; set; }

    /// <summary>
    /// Capital actual de la inversión (va creciendo cada mes)
    /// </summary>
    public decimal Saldo { get; set; }

    /// <summary>
    /// fecha en la que se calculó el capital
    /// </summary>
    public DateTime? FechaCalculo { get; set; }

    /// <summary>
    /// campo de observaciones libre
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    /// fecha de la compra (igual a compras.fecha_pago)
    /// </summary>
    public DateTime FechaCompra { get; set; }

    /// <summary>
    /// Fecha de inicio de operaciones del producto
    /// </summary>
    public DateTime? FechaInicio { get; set; }

    /// <summary>
    /// fecha de cierre del producto o plan
    /// </summary>
    public DateTime? FechaCierre { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public bool Etl { get; set; }

    public int? IdLegacy { get; set; }

    public virtual Compra CompraNavigation { get; set; } = null!;

    public virtual ICollection<Movimiento> Movimientos { get; } = new List<Movimiento>();

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual Promocione? PromocionNavigation { get; set; }

    public virtual ICollection<SocioAcumuladoNivel> SocioAcumuladoNivels { get; } = new List<SocioAcumuladoNivel>();

    public virtual Socio SocioNavigation { get; set; } = null!;

    public virtual ICollection<SolicitudesRetiro> SolicitudesRetiros { get; } = new List<SolicitudesRetiro>();
}
