using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Datos del (los) beneficiario(s) del socio
/// </summary>
public partial class SocioBeneficiario
{
    /// <summary>
    /// Id autonumérico del beneficiario
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

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
    /// email primario
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// email secundario
    /// </summary>
    public string? Email2 { get; set; }

    /// <summary>
    /// teléfono fijo de casa
    /// </summary>
    public string? TelCasa { get; set; }

    /// <summary>
    /// teléfono fijo del trabajo
    /// </summary>
    public string? TelOficina { get; set; }

    /// <summary>
    /// teléfono celular
    /// </summary>
    public string? TelCelular { get; set; }

    /// <summary>
    /// calle del domicilio del socio
    /// </summary>
    public string? Calle { get; set; }

    /// <summary>
    /// número exterior
    /// </summary>
    public string? NumExt { get; set; }

    /// <summary>
    /// número interior
    /// </summary>
    public string? NumInt { get; set; }

    /// <summary>
    /// colonia o barrio
    /// </summary>
    public string? Colonia { get; set; }

    /// <summary>
    /// municipio
    /// </summary>
    public string? Municipio { get; set; }

    /// <summary>
    /// ciudad
    /// </summary>
    public string? Ciudad { get; set; }

    /// <summary>
    /// código postal
    /// </summary>
    public string? CodigoPostal { get; set; }

    /// <summary>
    /// id del estado
    /// </summary>
    public int? Estado { get; set; }

    /// <summary>
    /// Id del país
    /// </summary>
    public int? Pais { get; set; }

    public DateTime? FechaInsert { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public virtual Estado? EstadoNavigation { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
