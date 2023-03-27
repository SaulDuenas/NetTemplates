using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Catálogo de smart packs
/// </summary>
public partial class Paquete
{
    /// <summary>
    /// id del paquete
    /// </summary>
    public int SmartPack { get; set; }

    /// <summary>
    /// Id autonumérico de la membresía
    /// </summary>
    public int? Membresia { get; set; }

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del producto
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// plan inicial al que está asociado éste smart pack
    /// </summary>
    public int PlanInicial { get; set; }

    /// <summary>
    /// Nuevo rendimiento del plan inicial si se convierte en smart pack (porcentaje expresado como fracción)
    /// </summary>
    public decimal Rendimiento { get; set; }

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

    public virtual Membresia? MembresiaNavigation { get; set; }

    public virtual ICollection<PaqueteProducto> PaqueteProductos { get; } = new List<PaqueteProducto>();

    public virtual Producto PlanInicialNavigation { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
