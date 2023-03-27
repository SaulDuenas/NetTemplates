using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class XPagosBlockchain
{
    public int IdKian { get; set; }

    public int Pago { get; set; }

    public int? Socio { get; set; }

    public string? Tipopago { get; set; }

    public decimal? Monto { get; set; }

    public string? Moneda { get; set; }

    public string? Wallet { get; set; }

    public decimal? Montobtc { get; set; }

    public decimal? Cotizabtc { get; set; }

    public string? Hash { get; set; }

    public string? Ticket { get; set; }

    public DateTime? Fecha { get; set; }
}
