using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla de prospectos, que están en proceso de convertirse en socios
/// </summary>
public partial class Prospecto
{
    /// <summary>
    /// Id del prospecto
    /// </summary>
    public int Prospecto1 { get; set; }

    /// <summary>
    /// 1=Prospecto, 2=Interesado
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// Nombre propio
    /// </summary>
    public string? Nombre { get; set; }

    /// <summary>
    /// apellido paterno
    /// </summary>
    public string? ApellidoPat { get; set; }

    /// <summary>
    /// apellido materno
    /// </summary>
    public string? ApellidoMat { get; set; }

    /// <summary>
    /// email del prospecto
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// contraseña encriptada
    /// </summary>
    public string? Contrasena { get; set; }

    /// <summary>
    /// indica si la dirección de correo ya fué verificada (con link en correo)
    /// </summary>
    public bool EmailVerified { get; set; }

    /// <summary>
    /// indica si el número telefónico ya fué verificado (con link en SMS)
    /// </summary>
    public bool PhoneVerified { get; set; }

    /// <summary>
    /// Id del socio padre
    /// </summary>
    public int Padre { get; set; }

    /// <summary>
    /// email alterno del socio
    /// </summary>
    public string? Email2 { get; set; }

    /// <summary>
    /// Cultura (Idioma) del socio (es-MX, en-US, ...) viene de microcatálogo
    /// </summary>
    public int? Cultura { get; set; }

    /// <summary>
    /// nombre canónico de la zona horaria del socio
    /// </summary>
    public string? ZonaHoraria { get; set; }

    public DateTime LastLogin { get; set; }

    /// <summary>
    /// Id de la validación
    /// </summary>
    public int? Validacion { get; set; }

    /// <summary>
    /// Id del socio en el que se convierte este prospecto
    /// </summary>
    public int? NuevoSocio { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual ICollection<Interaccione> Interacciones { get; } = new List<Interaccione>();

    public virtual Socio? NuevoSocioNavigation { get; set; }

    public virtual Socio PadreNavigation { get; set; } = null!;

    public virtual ICollection<ProspectoDocumentacion> ProspectoDocumentacions { get; } = new List<ProspectoDocumentacion>();

    public virtual ProspectoInfo? ProspectoInfo { get; set; }

    public virtual ProspectoMedium? ProspectoMedium { get; set; }

    public virtual ICollection<ProspectoValidacion> ProspectoValidacions { get; } = new List<ProspectoValidacion>();

    public virtual ProspectoValidacion? ValidacionNavigation { get; set; }
}
