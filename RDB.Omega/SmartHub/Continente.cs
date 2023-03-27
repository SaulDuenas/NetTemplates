using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// catálogo de continentes o regiones para agrupar países
/// </summary>
public partial class Continente
{
    /// <summary>
    /// Id del continente
    /// </summary>
    public int Continente1 { get; set; }

    /// <summary>
    /// Nombre del continente
    /// </summary>
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Paise> Paises { get; } = new List<Paise>();
}
