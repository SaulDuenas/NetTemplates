using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class PromoMembresia
{
    /// <summary>
    /// Id autonumérico de la membresía
    /// </summary>
    public int Membresia { get; set; }

    /// <summary>
    /// Id de la promoción
    /// </summary>
    public int Promocion { get; set; }

    /// <summary>
    /// precio promoción de la membresía
    /// </summary>
    public decimal Precio { get; set; }

    public virtual Membresia MembresiaNavigation { get; set; } = null!;

    public virtual Promocione PromocionNavigation { get; set; } = null!;
}
