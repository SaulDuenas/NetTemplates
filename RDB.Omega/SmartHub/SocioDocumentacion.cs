using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla almacena la documentación oficial del socio, como INE, CURP Comprobante de domicilio, etc
/// son puros anexos (Ver Notas)
/// 
/// 
/// </summary>
public partial class SocioDocumentacion
{
    /// <summary>
    /// id autonumérico del registro
    /// </summary>
    public int Anexo { get; set; }

    /// <summary>
    /// Folio autonumérico ID del registro
    /// </summary>
    public int? Validacion { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// tipo de documento (microcatálogo)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// nombre original del archivo (Ver Notas)
    /// </summary>
    public string Filename { get; set; } = null!;

    /// <summary>
    /// bandera que indica si el anexo ya fué descargado de metamap y alojado en un bucket
    /// </summary>
    public bool Descargado { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;

    public virtual SocioValidacion? ValidacionNavigation { get; set; }
}
