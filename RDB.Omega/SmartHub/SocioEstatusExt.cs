using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Guarda el estado de validación del socio hacia sistemas externos
/// </summary>
public partial class SocioEstatusExt
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Estatus que le da el servicio Zendesk.  0=PENDING, 1=OK, 2=WARNING, 3=FAIL
    /// </summary>
    public int EstatusZendesk { get; set; }

    /// <summary>
    /// fecha en que se verificó por el servicio KYC
    /// </summary>
    public DateTime? FechaZendesk { get; set; }

    /// <summary>
    /// Resultado en texto tal como lo devuelve el servicio KYC
    /// </summary>
    public string? ResultadoZendesk { get; set; }

    /// <summary>
    /// Observaciones (campo libre)
    /// </summary>
    public string? Observaciones { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
