using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Para procesar masivamente las compras con tdc de smart
/// </summary>
public partial class ZConciliacionTdc
{
    public string TransactionId { get; set; } = null!;

    public string? OrderId { get; set; }

    public string? OperationType { get; set; }

    public string? Description { get; set; }

    public string? CreationDate { get; set; }

    public string? OperationDate { get; set; }

    public string? Category { get; set; }

    public string? Estatus { get; set; }

    public string? Conciliated { get; set; }

    public string? Authorizationv { get; set; }

    public string? CardNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerLastname { get; set; }

    public string? Email { get; set; }

    public int Procesado { get; set; }

    public int? Prospecto { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountMxn { get; set; }

    public decimal? AmountUsd { get; set; }

    public string? Currency { get; set; }

    public string? Payload { get; set; }

    public int? Compra { get; set; }
}
