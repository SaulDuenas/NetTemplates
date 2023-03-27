using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class SocioEstrella
{
    public int Socio { get; set; }

    public int Estrellas { get; set; }

    public int Estatus { get; set; }

    public int? SocioApertura { get; set; }

    public DateTime? FechaApertura { get; set; }

    public int? FolioHistorico { get; set; }

    public DateTime FechaInsert { get; set; }
}
