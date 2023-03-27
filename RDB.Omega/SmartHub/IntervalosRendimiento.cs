using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla almacena intervalos de rendimiento (tabulador) en donde se ajusta el rendimiento a la baja en caso en el que se hagan retiros que disminuyan el capital inicial de inversión
/// los limites de cada intervalo están expresados como fracción (ej. 25% -&gt; 0.25)
/// al igual que la fracción del rendimiento aplicable al intevalo (ej. 75% -&gt; 0.75)
/// (Ver Notas)
/// </summary>
public partial class IntervalosRendimiento
{
    /// <summary>
    /// id del registro
    /// </summary>
    public int Intervalo { get; set; }

    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// Limite inferior del intervalo (expresado como fraccion (de 0 a 1))
    /// </summary>
    public double LimiteInf { get; set; }

    /// <summary>
    /// Limite superior del intervalo (expresado como fraccion (de 0 a 1))
    /// </summary>
    public double LimiteSup { get; set; }

    /// <summary>
    /// Fracción del porcentaje de rendimiento que queda al estar en éste intervalo
    /// </summary>
    public double FraccionRendimiento { get; set; }

    public virtual Producto ProductoNavigation { get; set; } = null!;
}
