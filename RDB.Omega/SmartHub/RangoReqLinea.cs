using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// catalogo de rangos requeridos por cada línea para alcanzar un rango específico
/// </summary>
public partial class RangoReqLinea
{
    /// <summary>
    /// Id autonumérico de la línea
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Rango en cuestión (de quien se están poniendo los requisitos)
    /// </summary>
    public int Rango { get; set; }

    /// <summary>
    /// Número de línea (1,2,3,...)
    /// </summary>
    public int NumLinea { get; set; }

    /// <summary>
    /// Rango requerido en la línea
    /// </summary>
    public int RangoReq { get; set; }

    /// <summary>
    /// cuantos socios de este rango_requerido se necesitan en esta línea (default=1)
    /// </summary>
    public int Cantidad { get; set; }

    public int? Version { get; set; }

    public virtual Rango RangoNavigation { get; set; } = null!;

    public virtual Rango RangoReqNavigation { get; set; } = null!;
}
