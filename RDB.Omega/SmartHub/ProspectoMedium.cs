using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// registra los archivos que ha descargado y videos que ha visto el prospecto
/// </summary>
public partial class ProspectoMedium
{
    /// <summary>
    /// Id del prospecto
    /// </summary>
    public int Prospecto { get; set; }

    /// <summary>
    /// porcentaje visto del video 1 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)
    /// </summary>
    public int Video1Visto { get; set; }

    /// <summary>
    /// porcentaje visto del video 2 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)
    /// </summary>
    public int Video2Visto { get; set; }

    /// <summary>
    /// porcentaje visto del video 3 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)
    /// </summary>
    public int Video3Visto { get; set; }

    /// <summary>
    /// descargó el manual de preguntas frecuentes
    /// </summary>
    public bool ManualPreguntas { get; set; }

    /// <summary>
    /// descargó el pdf informativo
    /// </summary>
    public bool PdfInformativo { get; set; }

    /// <summary>
    /// porcentaje visto del video 4 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)
    /// </summary>
    public int Video4Visto { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual Prospecto ProspectoNavigation { get; set; } = null!;
}
