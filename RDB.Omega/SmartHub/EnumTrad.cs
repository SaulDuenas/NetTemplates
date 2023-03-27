using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// traducciones de los enums
/// </summary>
public partial class EnumTrad
{
    /// <summary>
    /// Categoría del Enum (o nombre del microcatálogo)
    /// </summary>
    public string Categoria { get; set; } = null!;

    /// <summary>
    /// Valor numérico del elemento
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// clave del idioma (es=español, en=inglés, pt=portugues, jp=japonés)
    /// </summary>
    public string Idioma { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Svalor { get; set; }

    public string? Descripcion { get; set; }

    public virtual Enum C { get; set; } = null!;
}
