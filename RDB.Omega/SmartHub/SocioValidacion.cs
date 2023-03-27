using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Guarda el estado de la validación del socio (Ver notas)
/// </summary>
public partial class SocioValidacion
{
    /// <summary>
    /// Folio autonumérico ID del registro
    /// </summary>
    public int Validacion { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Estatus general (Ver Notas) 0=PENDING, 1=OK, 2=WARNING, 3=FAIL 
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// Fecha de validación interna
    /// </summary>
    public DateTime? FechaValidacion { get; set; }

    /// <summary>
    /// Estatus que le da el servicio KYC.  0=PENDING, 1=OK, 2=WARNING, 3=FAIL
    /// </summary>
    public int EstatusKyc { get; set; }

    /// <summary>
    /// Fecha en que se realizó la verificación por la empresa
    /// </summary>
    public DateTime? FechaEmpresa { get; set; }

    /// <summary>
    /// fecha en que se verificó por el servicio KYC
    /// </summary>
    public DateTime? FechaKyc { get; set; }

    /// <summary>
    /// Resultado en texto tal como lo devuelve el servicio KYC
    /// </summary>
    public string? ResultadoKyc { get; set; }

    /// <summary>
    /// Observaciones (campo libre)
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    /// usuario de SBC que realizó la validación
    /// </summary>
    public string? ValidadoPor { get; set; }

    /// <summary>
    /// usuario de SBC que autorizó al socio (en caso de tener warning o fail)
    /// </summary>
    public string? AutorizadoPor { get; set; }

    public string? Payload { get; set; }

    public string? IdValidation { get; set; }

    public string? IdRelated { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual ICollection<SocioDocumentacion> SocioDocumentacions { get; } = new List<SocioDocumentacion>();

    public virtual Socio SocioNavigation { get; set; } = null!;

    public virtual ICollection<Socio> Socios { get; } = new List<Socio>();
}
