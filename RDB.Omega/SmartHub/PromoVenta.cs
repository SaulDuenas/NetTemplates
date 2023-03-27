using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Registro de las ventas de una promoción
/// (un registro representa una promo vendida a un socio)
/// </summary>
public partial class PromoVenta
{
    /// <summary>
    /// folio autonumérico del registro
    /// </summary>
    public int Folio { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int Promocion { get; set; }

    /// <summary>
    /// Fecha-hora en la que el socio compró la promoción
    /// </summary>
    public DateTime Fecha { get; set; }

    public virtual Promocione PromocionNavigation { get; set; } = null!;

    public virtual Socio SocioNavigation { get; set; } = null!;
}
