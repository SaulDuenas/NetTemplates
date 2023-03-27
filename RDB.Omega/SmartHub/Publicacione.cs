using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class Publicacione
{
    /// <summary>
    /// Id autonumérico de la publicación
    /// </summary>
    public int Publicacion { get; set; }

    /// <summary>
    /// ¿uso?
    /// </summary>
    public int? Rango { get; set; }

    /// <summary>
    /// Tipo de publicación 1=Publicacion de Home, 2=Hack
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// Título de la publicación
    /// </summary>
    public string Titulo { get; set; } = null!;

    /// <summary>
    /// sinopsis de la publicación
    /// </summary>
    public string? Extracto { get; set; }

    /// <summary>
    /// Texto de la publicación con formato básico en html
    /// </summary>
    public string? Contenido { get; set; }

    /// <summary>
    /// texto del boton (Abrir, Ir, ver más, inscribirse, etc)
    /// </summary>
    public string TextoBoton { get; set; } = null!;

    /// <summary>
    /// liga del botón URL
    /// </summary>
    public string? LigaBoton { get; set; }

    /// <summary>
    /// ID del rango
    /// </summary>
    public int? RangoDesde { get; set; }

    /// <summary>
    /// publicación activa (se muestra)
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// Indica si se trata de un borrador (no se muestra)
    /// </summary>
    public bool EsBorrador { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public bool? Descarga { get; set; }

    public string? Imagen { get; set; }

    public short? Idcultura { get; set; }

    public virtual ICollection<PubCateg> PubCategs { get; } = new List<PubCateg>();

    public virtual Rango? RangoDesdeNavigation { get; set; }

    public virtual ICollection<Paise> Pais { get; } = new List<Paise>();

    public virtual ICollection<Recurso> Recursos { get; } = new List<Recurso>();
}
