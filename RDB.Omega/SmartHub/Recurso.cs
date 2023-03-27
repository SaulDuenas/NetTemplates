using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// contiene la biblioteca de recursos (videos, imágenes, documentos, etc)
/// </summary>
public partial class Recurso
{
    /// <summary>
    /// id autonumérico del recurso
    /// </summary>
    public int Recurso1 { get; set; }

    /// <summary>
    /// nombre del recurso
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// descripción del recurso
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// tipo del recurso (en enum &quot;TipoRecurso&quot;)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// nombre original del archivo
    /// </summary>
    public string Filename { get; set; } = null!;

    /// <summary>
    /// nombre del archivo de miniatura (siempre jpg)
    /// </summary>
    public string? FilenameMini { get; set; }

    /// <summary>
    /// tamaño del archivo en bytes
    /// </summary>
    public int Filesize { get; set; }

    /// <summary>
    /// extensión del archivo (mp4, pdf, jpg, etcétera)
    /// </summary>
    public string Extension { get; set; } = null!;

    /// <summary>
    /// url del recurso (en caso de liga externa)
    /// </summary>
    public string? Link { get; set; }

    public DateTime? FechaInsert { get; set; }

    public bool? Descarga { get; set; }

    public bool? Habilitar { get; set; }

    public short? Idcultura { get; set; }

    public virtual ICollection<Interaccione> Interaccions { get; } = new List<Interaccione>();

    public virtual ICollection<Publicacione> Publicacions { get; } = new List<Publicacione>();
}
