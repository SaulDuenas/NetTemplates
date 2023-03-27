using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Almacena la lista de asignaciones del socio.
/// 
/// Asignaciones de la regla de bonos 5-1
/// </summary>
public partial class SocioListaAsig
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    public short Posicion { get; set; }

    public int Valor { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
