using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Catálogo de productos
/// 
/// Guarda la lista de productos (planes iniciales y adicionales)
/// 
/// No guarda productos resultantes de una promo, son los productos básicos, si acaso, llegan a ser diferentes por región.
/// </summary>
public partial class Producto
{
    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto1 { get; set; }

    /// <summary>
    /// 1=Plan Inicial, 2=Plan Adicional (Enum TipoProducto)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// Nombre clave del producto (llave alterna)
    /// </summary>
    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Monto o precio de la inversión o producto
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// Moneda (Enum Monedas [sValor])
    /// </summary>
    public string Moneda { get; set; } = null!;

    /// <summary>
    /// Indica que se trata de un monto abierto (en ese caso el campo monto trae el mínimo por ejemplo 10,000 USD)
    /// </summary>
    public bool EsMontoAbierto { get; set; }

    /// <summary>
    /// se puede pagar con bitcoins
    /// </summary>
    public bool PagoBtc { get; set; }

    /// <summary>
    /// se puede pagar con tarjeta de crédito o débito
    /// </summary>
    public bool PagoTdc { get; set; }

    /// <summary>
    /// Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)
    /// </summary>
    public decimal Rendimiento { get; set; }

    /// <summary>
    /// Viene de microcatálogo (ReglasCapitalizacion) 1=Mensual, 2=Quincenal
    /// </summary>
    public int ReglaCapitalizacion { get; set; }

    /// <summary>
    /// porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)
    /// </summary>
    public decimal Comision { get; set; }

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
    /// Si tipo=1 (plan inicial) este campo apunta al smart pack al que se puede convertir este plan
    /// </summary>
    public int? SmartPack { get; set; }

    /// <summary>
    /// indica si el producto está activo (es susceptible a ser comprado)
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// color del encabezado del producto como se muestra en la web
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// indica que el registro es un borrador (no está capturado correctamente o autorizado)
    /// </summary>
    public bool EsBorrador { get; set; }

    /// <summary>
    /// fecha de inicio de vigencia (a partir de cuando se puede comprar)
    /// </summary>
    public DateTime FechaIni { get; set; }

    /// <summary>
    /// fecha determinación de vigencia (cuando se dejó de vender)
    /// </summary>
    public DateTime? FechaFin { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    /// <summary>
    /// Indica si el producto es heredado del sistema anterior y no debe ser vendido más
    /// </summary>
    public bool? EsLegacy { get; set; }

    public bool Etl { get; set; }

    /// <summary>
    /// Id del elemento en la tabla legacy
    /// </summary>
    public int? IdLegacy { get; set; }

    public virtual ICollection<IntervalosRendimiento> IntervalosRendimientos { get; } = new List<IntervalosRendimiento>();

    public virtual ICollection<Membresia> Membresia { get; } = new List<Membresia>();

    public virtual ICollection<PaqueteProducto> PaqueteProductos { get; } = new List<PaqueteProducto>();

    public virtual ICollection<Paquete> Paquetes { get; } = new List<Paquete>();

    public virtual ICollection<ProductosTrad> ProductosTrads { get; } = new List<ProductosTrad>();

    public virtual ICollection<PromoProducto> PromoProductos { get; } = new List<PromoProducto>();

    public virtual Paquete? SmartPackNavigation { get; set; }

    public virtual ICollection<Paise> Pais { get; } = new List<Paise>();
}
