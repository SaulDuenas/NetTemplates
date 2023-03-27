using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZNivel
{
    public long? SubscriberId { get; set; }

    public int? Nivl { get; set; }

    public long? IdCalificado { get; set; }

    public DateOnly? FechaValidoPago { get; set; }

    public decimal? SaldoAcumulado { get; set; }

    public decimal? SaldoPendiente { get; set; }

    public decimal? SaldoLimite { get; set; }

    public double? AplicaPorcent { get; set; }

    public long? IdDeposito { get; set; }

    public DateOnly? ChecarFecha { get; set; }

    public DateOnly? FechaInicioAcumulado { get; set; }

    public DateOnly? FechaPeriodo { get; set; }

    public int? Cerrado { get; set; }

    public int? Estado { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaPreLimite { get; set; }

    public DateOnly? FechaLimite { get; set; }

    public DateTime? FechaReg { get; set; }

    public DateTime? FechaUpd { get; set; }

    public decimal? SaldoPrelimite { get; set; }
}
