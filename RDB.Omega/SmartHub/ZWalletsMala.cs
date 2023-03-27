using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZWalletsMala
{
    public int? Socio { get; set; }

    public int? NumWallet { get; set; }

    public int? Criptomoneda { get; set; }

    public string? Wallet { get; set; }

    public bool? Activa { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaInsert { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool? Validado { get; set; }

    public DateOnly? FechaValidacion { get; set; }
}
