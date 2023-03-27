using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Almacena los productos participantes en la promo. 
/// La promo aplica para cualquiera de los productos que están en esta lista
/// (Ver Notas)
/// 
/// </summary>
public partial class PromoProducto
{
    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int Promocion { get; set; }

    /// <summary>
    /// Monto o precio de la inversión o producto
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)
    /// </summary>
    public decimal Rendimiento { get; set; }

    /// <summary>
    /// porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)
    /// </summary>
    public decimal Comision { get; set; }

    /// <summary>
    /// duración en meses del plazo mínimo para no causar comisiones al retirar 
    /// </summary>
    public int PlazoComision { get; set; }

    public virtual Producto ProductoNavigation { get; set; } = null!;

    public virtual Promocione PromocionNavigation { get; set; } = null!;
}
