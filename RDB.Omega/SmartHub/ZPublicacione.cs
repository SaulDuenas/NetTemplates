using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZPublicacione
{
    public int? Publicacion { get; set; }

    public int? Rango { get; set; }

    public int? Tipo { get; set; }

    public string? Titulo { get; set; }

    public string? Extracto { get; set; }

    public string? Contenido { get; set; }

    public string? TextoBoton { get; set; }

    public string? LigaBoton { get; set; }

    public int? RangoDesde { get; set; }

    public bool? Activo { get; set; }

    public bool? EsBorrador { get; set; }

    public DateTime? FechaInsert { get; set; }

    public DateTime? FechaUpdate { get; set; }
}
