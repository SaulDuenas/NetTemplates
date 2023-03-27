using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla contiene los productos que componen a cada paquete
/// </summary>
public partial class PaqueteProducto
{
    /// <summary>
    /// id del paquete
    /// </summary>
    public int SmartPack { get; set; }

    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// rendimiento del producto al convertirse en un smart pack
    /// </summary>
    public decimal Rendimiento { get; set; }

    public virtual Producto ProductoNavigation { get; set; } = null!;

    public virtual Paquete SmartPackNavigation { get; set; } = null!;
}
