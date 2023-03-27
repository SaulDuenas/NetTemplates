using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Catálogo de promociones (Ver Notas)
/// 
/// 
/// </summary>
public partial class Promocione
{
    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int Promocion { get; set; }

    /// <summary>
    /// Id autonumérico del premio
    /// </summary>
    public int? Premio { get; set; }

    /// <summary>
    /// Id de la insignia
    /// </summary>
    public int? Insignia { get; set; }

    /// <summary>
    /// Código (nombre corto) de la promoción
    /// </summary>
    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Nombre de la promoción
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// descripción de la promo
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// porcentaje de rendimiento adicional al normal (expresado como fracción)
    /// </summary>
    public decimal RendimientoExtra { get; set; }

    /// <summary>
    /// solo se puede vender N veces esta promo (0=sin límite)
    /// </summary>
    public int TirajeLimitado { get; set; }

    /// <summary>
    /// sólo se puede vender hasta alcanzar esta cantidad en ventas (dinero) 0=sin límite
    /// </summary>
    public decimal? MontoLimitado { get; set; }

    /// <summary>
    /// Indica si solo puede ser comprado por socios de cierto rango (especificados en promo_rangos)
    /// </summary>
    public bool ExclusivoRangos { get; set; }

    /// <summary>
    /// Porcentaje de descuento para la compra de un producto
    /// </summary>
    public decimal? DescuentoPorcentaje { get; set; }

    /// <summary>
    /// Descuento en monto fijo para la compra de un producto 
    /// </summary>
    public decimal? DescuentoMonto { get; set; }

    /// <summary>
    /// Condición de Insignias (ver notas)
    /// </summary>
    public bool? InsigniasAnd { get; set; }

    /// <summary>
    /// Indica cuantas veces se ha vendido la promo
    /// </summary>
    public int VentasConteo { get; set; }

    /// <summary>
    /// Suma en dólares de las ventas de la promo
    /// </summary>
    public decimal? VentasMonto { get; set; }

    /// <summary>
    /// campo libre
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    /// indica si la promoción está activa (se puede comprar)
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// indica si el registro es un borrador (se puede editar libremente)
    /// </summary>
    public bool EsBorrador { get; set; }

    /// <summary>
    /// fecha-hora de inicio de la promoción (Desde cuando se puede comprar)
    /// </summary>
    public DateTime FechaIni { get; set; }

    /// <summary>
    /// fechaHora final de la promoción (Hasta cuando se puede comprar)
    /// </summary>
    public DateTime FechaFin { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual Insignia? Insignia1 { get; set; }

    public virtual Premio? PremioNavigation { get; set; }

    public virtual ICollection<PromoMembresia> PromoMembresia { get; } = new List<PromoMembresia>();

    public virtual ICollection<PromoProducto> PromoProductos { get; } = new List<PromoProducto>();

    public virtual ICollection<PromoVenta> PromoVenta { get; } = new List<PromoVenta>();

    public virtual ICollection<SocioProducto> SocioProductos { get; } = new List<SocioProducto>();

    public virtual ICollection<Insignia> InsigniaNavigation { get; } = new List<Insignia>();

    public virtual ICollection<Paise> Pais { get; } = new List<Paise>();

    public virtual ICollection<Rango> Rangos { get; } = new List<Rango>();
}
