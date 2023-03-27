using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Catálogo de zonas horarias
/// es un subconjunto de las existentes en la vista de sistema &quot;pg_timezone_names&quot;
/// pero está relacionada con países.
/// 
/// La columna utc_offset es una copia de la de &quot;pg_timezones_names&quot;, es sólo para fines de despliegue, no para hacer cálculos... en cuyo caso se debe usar la de la vista.
/// </summary>
public partial class ZonasHoraria
{
    /// <summary>
    /// Nombre canónico de la zona horaria
    /// </summary>
    public string ZonaHoraria { get; set; } = null!;

    /// <summary>
    /// Id del país
    /// </summary>
    public int Pais { get; set; }

    /// <summary>
    /// Offset con respecto a UTC
    /// </summary>
    public TimeSpan UtcOffset { get; set; }

    public virtual Paise PaisNavigation { get; set; } = null!;
}
