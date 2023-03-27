using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZTipoInteraccione
{
    public int? Tipo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fechainsert { get; set; }

    public DateTime? Fechaupdate { get; set; }
}
