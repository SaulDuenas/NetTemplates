using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// traducción de los productos
/// </summary>
public partial class ProductosTrad
{
    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// id del idioma (es,en,pt,jp)
    /// </summary>
    public string Idioma { get; set; } = null!;

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string? Nombre { get; set; }

    /// <summary>
    /// Descripción del producto
    /// </summary>
    public string? Descripcion { get; set; }

    public virtual Producto ProductoNavigation { get; set; } = null!;
}
