using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// 
/// 
/// tabla de movimientos diarios
/// </summary>
public partial class Movimiento
{
    /// <summary>
    /// folio autonumérico
    /// </summary>
    public int Folio { get; set; }

    /// <summary>
    /// id del plan
    /// </summary>
    public int Plan { get; set; }

    /// <summary>
    /// fecha y hora del movimiento
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// tipo de movimiento (1=Rendimiento, 2=Retiro)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// número de mes consecutivo, desde que se inició el plan
    /// </summary>
    public int Mes { get; set; }

    /// <summary>
    /// día de la semana (LU, MA, MI...)
    /// </summary>
    public string Dia { get; set; } = null!;

    /// <summary>
    /// porcentaje diario de rendimiento (como fracción) (para rendimiento)
    /// </summary>
    public decimal? PorcentajeDiario { get; set; }

    /// <summary>
    /// cantidad de rendimientos generada en el día
    /// </summary>
    public decimal? Abono { get; set; }

    /// <summary>
    /// monto retirado (ver notas)
    /// </summary>
    public decimal? Cargo { get; set; }

    /// <summary>
    /// comisión descontada por el retiro
    /// </summary>
    public decimal? Comision { get; set; }

    /// <summary>
    /// Capital resultante después del movimiento de cargo o abono (Ver notas)
    /// </summary>
    public decimal Capital { get; set; }

    /// <summary>
    /// pago con el que se saldó el retiro
    /// </summary>
    public int? Pago { get; set; }

    /// <summary>
    /// id de la DB legacy
    /// </summary>
    public int? IdAux { get; set; }

    /// <summary>
    /// otro id de legacy
    /// </summary>
    public int? IdAux2 { get; set; }

    public decimal? CapitalPrevio { get; set; }

    public virtual Pago? PagoNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual SocioProducto PlanNavigation { get; set; } = null!;
}
