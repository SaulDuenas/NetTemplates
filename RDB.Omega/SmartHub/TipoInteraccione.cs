using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class TipoInteraccione
{
    public int Tipo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime Fechainsert { get; set; }

    public DateTime Fechaupdate { get; set; }

    public virtual ICollection<Interaccione> Interacciones { get; } = new List<Interaccione>();
}
