using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZInteraccione
{
    public int? Interaccion { get; set; }

    public int? Prospecto { get; set; }

    public int? Tipo { get; set; }

    public string? Titulo { get; set; }

    public string? Url { get; set; }

    public string? Cuerpo { get; set; }

    public bool? Enviado { get; set; }

    public DateTime? Fechaenvio { get; set; }

    public DateTime? Fechaentrega { get; set; }

    public bool? Leido { get; set; }

    public DateTime? Fechalectura { get; set; }

    public string? Comentarios { get; set; }

    public DateTime? Fechainsert { get; set; }

    public DateTime? Fechaupdate { get; set; }
}
