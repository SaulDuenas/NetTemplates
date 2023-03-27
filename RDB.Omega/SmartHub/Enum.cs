using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla guarda listas de valores con sus descripciones. (O sea Enumeraciones)
/// 
/// Además también almacena microcatálogos (Funciona como Tabla de Tablas)
/// para casos en los que los ID son numéricos.
/// </summary>
public partial class Enum
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
    /// Nombre del elemento
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// valor auxiliar numérico
    /// </summary>
    public double? Nvalor { get; set; }

    /// <summary>
    /// valor auxiliar string
    /// </summary>
    public string? Svalor { get; set; }

    /// <summary>
    /// valor auxiliar datetime
    /// </summary>
    public DateTime? Dvalor { get; set; }

    /// <summary>
    /// Descripción del elemento
    /// </summary>
    public string? Descripcion { get; set; }

    public virtual ICollection<EnumTrad> EnumTrads { get; } = new List<EnumTrad>();
}
