using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla de parámetros de configuración del sistema
/// 
/// Almacena diversos parámetros de funcionamiento del sistema.
/// 
/// </summary>
public partial class Parametro
{
    /// <summary>
    /// Categoría del parámetro
    /// </summary>
    public string Categoria { get; set; } = null!;

    /// <summary>
    /// Nombre del parámetro
    /// </summary>
    public string Parametro1 { get; set; } = null!;

    /// <summary>
    /// Valor numérico del parámetro
    /// </summary>
    public double? Nvalor { get; set; }

    /// <summary>
    /// Valor string del parámetro
    /// </summary>
    public string? Svalor { get; set; }

    /// <summary>
    /// valor datetime del parámetro
    /// </summary>
    public DateTime? Dvalor { get; set; }

    /// <summary>
    /// Descripción del Parámetro
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// n=Numérico, s=String, d=Date
    /// </summary>
    public string? Tipo { get; set; }

    /// <summary>
    /// intervalo de valores válidos en formato a-b (puede ser a-  o -b)
    /// </summary>
    public string? Rango { get; set; }

    /// <summary>
    /// Indica si es un parámetro configurable por el usuario
    /// </summary>
    public bool Eseditable { get; set; }
}
