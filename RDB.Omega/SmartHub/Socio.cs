using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla de socios, almacena sólo socios que ya tienen al menos la membresía
/// </summary>
public partial class Socio
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio1 { get; set; }

    /// <summary>
    /// Nombre propio
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// apellido paterno
    /// </summary>
    public string ApellidoPat { get; set; } = null!;

    /// <summary>
    /// apellido materno
    /// </summary>
    public string? ApellidoMat { get; set; }

    /// <summary>
    /// Id autonumérico de la membresía
    /// </summary>
    public int Membresia { get; set; }

    /// <summary>
    /// email del socio
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// contraseña encriptada
    /// </summary>
    public string Contrasena { get; set; } = null!;

    /// <summary>
    /// indica si la dirección de correo ya fué verificada (con link en correo)
    /// </summary>
    public bool EmailVerified { get; set; }

    /// <summary>
    /// indica si el número telefónico ya fué verificado (con link en SMS)
    /// </summary>
    public bool PhoneVerified { get; set; }

    /// <summary>
    /// indica si el usuario es empleado de SBC
    /// </summary>
    public bool EsEmpleado { get; set; }

    /// <summary>
    /// Id del socio padre (upline)
    /// </summary>
    public int? Padre { get; set; }

    /// <summary>
    /// email alterno del socio
    /// </summary>
    public string? Email2 { get; set; }

    /// <summary>
    /// Cultura (Idioma) del socio (es-MX, en-US, ...) viene de microcatálogo
    /// </summary>
    public int Cultura { get; set; }

    /// <summary>
    /// Estatus del socio (1=Activo, 2=Bloqueado, 3=Borrado)
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// nombre canónico de la zona horaria del socio
    /// </summary>
    public string ZonaHoraria { get; set; } = null!;

    /// <summary>
    /// Fecha en la que ingresó el socio a la organización
    /// </summary>
    public DateTime FechaIngreso { get; set; }

    /// <summary>
    /// Folio de la validación más reciente
    /// </summary>
    public int? Validacion { get; set; }

    /// <summary>
    /// Id del socio antecesor a quien este socio está asignado (regla 5-1)
    /// </summary>
    public int? AsignadoA { get; set; }

    /// <summary>
    /// fecha y hora del ultimo login
    /// </summary>
    public DateTime LastLogin { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public bool Etl { get; set; }

    public DateTime? FechaVigenciaSmartpack { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaVigenciaMembresia { get; set; }

    public bool? BonoUnico { get; set; }

    public DateTime? FechaLimiteBeneficios { get; set; }

    public virtual Socio? AsignadoANavigation { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual ICollection<Socio> InverseAsignadoANavigation { get; } = new List<Socio>();

    public virtual Membresia MembresiaNavigation { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<PagosTransaccione> PagosTransacciones { get; } = new List<PagosTransaccione>();

    public virtual ICollection<PromoVenta> PromoVenta { get; } = new List<PromoVenta>();

    public virtual ICollection<Prospecto> ProspectoNuevoSocioNavigations { get; } = new List<Prospecto>();

    public virtual ICollection<Prospecto> ProspectoPadreNavigations { get; } = new List<Prospecto>();

    public virtual ICollection<SocioAcumuladoNivel> SocioAcumuladoNivels { get; } = new List<SocioAcumuladoNivel>();

    public virtual ICollection<SocioBeneficiario> SocioBeneficiarios { get; } = new List<SocioBeneficiario>();

    public virtual ICollection<SocioDocumentacion> SocioDocumentacions { get; } = new List<SocioDocumentacion>();

    public virtual SocioEstatusExt? SocioEstatusExt { get; set; }

    public virtual SocioInfo? SocioInfo { get; set; }

    public virtual ICollection<SocioListaAsig> SocioListaAsigs { get; } = new List<SocioListaAsig>();

    public virtual ICollection<SocioProducto> SocioProductos { get; } = new List<SocioProducto>();

    public virtual ICollection<SocioRenovacione> SocioRenovaciones { get; } = new List<SocioRenovacione>();

    public virtual ICollection<SocioValidacion> SocioValidacions { get; } = new List<SocioValidacion>();

    public virtual ICollection<SocioWallet> SocioWallets { get; } = new List<SocioWallet>();

    public virtual SocioValidacion? ValidacionNavigation { get; set; }

    public virtual ICollection<Insignia> Insignia { get; } = new List<Insignia>();
}
