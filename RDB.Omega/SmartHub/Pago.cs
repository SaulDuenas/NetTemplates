using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// tabla que almacena los pagos realizados o por realizar al socio, ya sea por retiros o bonos
/// </summary>
public partial class Pago
{
    /// <summary>
    /// folio autonumérico del pago
    /// </summary>
    public int Pago1 { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Tipo de pago (Ver notas)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// Monto a pagar en USD
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// fecha en que se creó la solicitud de pago
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// Estatus del pago (0=Sin pagar, 1=Pagado)
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// fecha en que se debe realizar el pago
    /// </summary>
    public DateTime FechaPago { get; set; }

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

    /// <summary>
    /// socio que generó el bono (afiliado directo, 3er afiliado,...)
    /// </summary>
    public int? RefSocio { get; set; }

    /// <summary>
    /// referencia al retiro (movimientos.folio)
    /// </summary>
    public int? RefRetiro { get; set; }

    /// <summary>
    /// referencia al plan adicional que generó el bono 5-3-2
    /// </summary>
    public int? RefPlan { get; set; }

    /// <summary>
    /// referencia al rango del socio que generó el bono (socio_kpi_hist.folio)
    /// </summary>
    public int? RefMasterbonus { get; set; }

    /// <summary>
    /// Indica si ya se envió el correo de confirmación de pago
    /// </summary>
    public bool? CorreoEnviado { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    /// <summary>
    /// id del depósito en la DB legacy
    /// </summary>
    public int? IdAux { get; set; }

    /// <summary>
    /// id del evento o plan en legacy que generó el bono
    /// </summary>
    public int? IdAux2 { get; set; }

    public string? Observaciones { get; set; }

    public int? RefPadrino { get; set; }

    public int? PagoTx { get; set; }

    public virtual ICollection<Movimiento> Movimientos { get; } = new List<Movimiento>();

    public virtual PagosTransaccione? PagoTxNavigation { get; set; }

    public virtual SocioProducto? RefPlanNavigation { get; set; }

    public virtual Movimiento? RefRetiroNavigation { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
