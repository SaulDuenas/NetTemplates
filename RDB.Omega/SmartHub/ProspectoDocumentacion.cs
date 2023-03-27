using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla almacena la documentación oficial del prospecto, como INE, CURP Comprobante de domicilio, etc
/// son puros anexos (Ver Notas)
/// 
/// 
/// </summary>
public partial class ProspectoDocumentacion
{
    /// <summary>
    /// id autonumérico del registro
    /// </summary>
    public int Anexo { get; set; }

    /// <summary>
    /// Id de la validación
    /// </summary>
    public int Validacion { get; set; }

    /// <summary>
    /// Id del prospecto
    /// </summary>
    public int Prospecto { get; set; }

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

    public virtual Prospecto ProspectoNavigation { get; set; } = null!;

    public virtual ProspectoValidacion ValidacionNavigation { get; set; } = null!;
}
