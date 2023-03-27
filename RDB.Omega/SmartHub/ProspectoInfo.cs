﻿using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Información adicional sobre el prospecto
/// </summary>
public partial class ProspectoInfo
{
    /// <summary>
    /// Id del prospecto
    /// </summary>
    public int Prospecto { get; set; }

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
    /// código de validación de celular (se envia como SMS cada que se valida el celular) (No se usa para autentificación)
    /// </summary>
    public int? CodigoMfa { get; set; }

    /// <summary>
    /// Medio de contacto preferido. (1=email, 2=WhatsApp, 3=sms, 4=Otro) microcatálogo
    /// </summary>
    public int? MedioContacto { get; set; }

    /// <summary>
    /// Otro medio de contacto (cuando el preferido es 4=Otro)
    /// </summary>
    public string? MedioContactoOtro { get; set; }

    /// <summary>
    /// tiene interés en formación (educación financiera)
    /// </summary>
    public bool? IntFormacion { get; set; }

    /// <summary>
    /// tiene interés en ahorro (inversiones)
    /// </summary>
    public bool? IntAhorro { get; set; }

    /// <summary>
    /// tiene interés en networking (red multinivel)
    /// </summary>
    public bool? IntNetworking { get; set; }

    /// <summary>
    /// tiene interés en emprendimiento
    /// </summary>
    public bool? IntEmprendimiento { get; set; }

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

    /// <summary>
    /// Dirección completa
    /// </summary>
    public string? Direccion { get; set; }

    /// <summary>
    /// Nombre del archivo foto (ver notas)
    /// </summary>
    public string? Foto { get; set; }

    /// <summary>
    /// bandera que indica si la foto ya fue descargada de metamap y puesta en un bucket
    /// </summary>
    public bool FotoDescargada { get; set; }

    /// <summary>
    /// clave oficial de identificación oficial (En méxico INE, en españa DNI)
    /// </summary>
    public string? CveIdentidad { get; set; }

    /// <summary>
    /// Clave fiscal de la persona (en méxico RFC)
    /// </summary>
    public string? CveFiscal { get; set; }

    /// <summary>
    /// fecha de nacimiento del socio
    /// </summary>
    public DateOnly? FechaNacimiento { get; set; }

    /// <summary>
    /// 1=Hombre, 2=Mujer, 3=Otro, ... (Microcatálogo)
    /// </summary>
    public int? Genero { get; set; }

    /// <summary>
    /// campo libre para comentarios
    /// </summary>
    public string? Comentarios { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual Estado? EstadoNavigation { get; set; }

    public virtual Prospecto ProspectoNavigation { get; set; } = null!;
}
