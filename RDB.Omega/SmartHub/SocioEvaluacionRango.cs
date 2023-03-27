using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla para almacenar los nodos pendientes por procesar su rango
/// </summary>
public partial class SocioEvaluacionRango
{
    public int Folio { get; set; }

    public int Socio { get; set; }

    public int? Plan { get; set; }

    public int Origen { get; set; }

    public int Estatus { get; set; }

    public int? Resultado { get; set; }

    public int Procesado { get; set; }

    public DateTime? Fechaproceso { get; set; }

    public DateTime Fechainsert { get; set; }

    public DateTime Fechaupdate { get; set; }
}
