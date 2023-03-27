using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class PagosTransaccione
{
    /// <summary>
    /// folio autonumérico del pago-transacción
    /// </summary>
    public int PagoTx { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Monto a pagar en USD (Suma de los pagos individuales)
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// Estatus del pago (0=Sin pagar, 1=Pagado)
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// fecha y hora en que se realizó el pago
    /// </summary>
    public DateTime? FechaPagado { get; set; }

    /// <summary>
    /// clave de wallet a la que se debe hacer el pago
    /// </summary>
    public string? Wallet { get; set; }

    /// <summary>
    /// Referencia de la operación (hash o numero de transferencia)
    /// </summary>
    public string? Hash { get; set; }

    /// <summary>
    /// Monto pagado en btc
    /// </summary>
    public decimal? MontoPagadoBtc { get; set; }

    /// <summary>
    /// cotización del btc de la operación
    /// </summary>
    public decimal? CotizaBtc { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual Socio SocioNavigation { get; set; } = null!;
}
