using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZRecurso
{
    public int? Recurso { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Tipo { get; set; }

    public string? Filename { get; set; }

    public string? FilenameMini { get; set; }

    public int? Filesize { get; set; }

    public string? Extension { get; set; }

    public string? Link { get; set; }

    public DateTime? FechaInsert { get; set; }
}
