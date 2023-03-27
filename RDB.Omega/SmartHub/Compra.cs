using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Esta tabla almacena solicitudes de compra de los socios
/// pueden quedarse solo como intensión o concretarse en compra efectiva
/// </summary>
public partial class Compra
{
    /// <summary>
    /// Folio autonumérico de la compra o intención de compra
    /// </summary>
    public int Compra1 { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int? Socio { get; set; }

    /// <summary>
    /// Id del prospecto
    /// </summary>
    public int? Prospecto { get; set; }

    /// <summary>
    /// Tipo de Item que se compra: 1=Membresía, 2=Plan Adicional, 3=SmartPack, (Si fue en promoción, el dato viene en el campo promoción)
    /// </summary>
    public int TipoItem { get; set; }

    /// <summary>
    /// Clave del item (membresía, plan adicional o smart pack) (Ver Notas)
    /// </summary>
    public int Item { get; set; }

    /// <summary>
    /// Clave del plan adicional (sólo cuando tipo_item=3:smart_pack) (Ver Notas del campo Item)
    /// </summary>
    public int? Item2 { get; set; }

    /// <summary>
    /// Forma de pago (enum FormaPago) 1=Bitcoins, 2=Tarjeta, 3=Transferencia
    /// </summary>
    public int FormaPago { get; set; }

    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int? Promocion { get; set; }

    /// <summary>
    /// clave de la wallet de destino a la que el usuario debe pagar (es única por transacción)
    /// </summary>
    public string? WalletDestino { get; set; }

    /// <summary>
    /// Precio en moneda fiat (USD normalmente)
    /// </summary>
    public decimal Precio { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    public string Moneda { get; set; } = null!;

    /// <summary>
    /// Precio en bitcoins
    /// </summary>
    public decimal? PrecioBtc { get; set; }

    /// <summary>
    /// cotización del bitcoin en fiat (cuantos bitcoins por dolar)
    /// </summary>
    public decimal? CotizaBtc { get; set; }

    /// <summary>
    /// 1=Compra solicitada, 2=Confirmando pago, 3=Pago Insuficiente, 4=Pagado (Ver Notas de la tabla)
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// avance del pago (del 0 al 4)
    /// </summary>
    public int AvancePago { get; set; }

    /// <summary>
    /// Monto en fiat (USD) que pagó el cliente
    /// </summary>
    public decimal? MontoPagado { get; set; }

    /// <summary>
    /// Monto en BTC que pagó el cliente
    /// </summary>
    public decimal? MontoPagadoBtc { get; set; }

    /// <summary>
    /// Indica si el pago fué insuficiente (aunque después se haya subsanado y el estatus haya pasado a Pagado)
    /// </summary>
    public bool? FueInsuficiente { get; set; }

    /// <summary>
    /// indica si este registro es un pago complementario de uno anterior (indicado en &quot;complemento_de&quot;)
    /// </summary>
    public bool? EsComplementario { get; set; }

    /// <summary>
    /// Folio autonumérico de la compra o intención de compra
    /// </summary>
    public int? ComplementoDe { get; set; }

    /// <summary>
    /// Indica si el pago se realizó en exceso
    /// </summary>
    public bool? EsExcedido { get; set; }

    /// <summary>
    /// Fecha y hora de la recepción del pago (debe quedar dentro de los 5 minutos)
    /// </summary>
    public DateTime? FechaPago { get; set; }

    /// <summary>
    /// cotización del bitcoin en fiat (Cuando el tiempo se excedió a los 5 minutos se actualizó)
    /// </summary>
    public decimal? CotizaBtc2 { get; set; }

    /// <summary>
    /// Hash de la transferencia en bitcoins
    /// </summary>
    public string? Hash { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    /// <summary>
    /// Indica si el registro proviene de la migración con ETL
    /// </summary>
    public bool? Etl { get; set; }

    /// <summary>
    /// ID del registro original en la db legacy (MySql)
    /// </summary>
    public int? IdLegacy { get; set; }

    public virtual Compra? ComplementoDeNavigation { get; set; }

    public virtual ICollection<Compra> InverseComplementoDeNavigation { get; } = new List<Compra>();

    public virtual Promocione? PromocionNavigation { get; set; }

    public virtual Prospecto? ProspectoNavigation { get; set; }

    public virtual Socio? SocioNavigation { get; set; }

    public virtual ICollection<SocioProducto> SocioProductos { get; } = new List<SocioProducto>();

    public virtual ICollection<SocioRenovacione> SocioRenovaciones { get; } = new List<SocioRenovacione>();
}
