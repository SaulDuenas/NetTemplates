using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Catálogo de insignias. (Ver Notas)
/// 
/// 
/// </summary>
public partial class Insignia
{
    /// <summary>
    /// Id de la insignia
    /// </summary>
    public int Insignia1 { get; set; }

    /// <summary>
    /// Nombre de la insignia
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la insignia
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// Nombre del archivo del icono de la insignia
    /// </summary>
    public string Icono { get; set; } = null!;

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual ICollection<Promocione> Promociones { get; } = new List<Promocione>();

    public virtual ICollection<Promocione> Promocions { get; } = new List<Promocione>();

    public virtual ICollection<Socio> Socios { get; } = new List<Socio>();
}
