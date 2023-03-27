using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Histórico de renovación de membresías
/// </summary>
public partial class SocioRenovacione
{
    /// <summary>
    /// folio autonumérico de la renovación de membresía
    /// </summary>
    public int Folio { get; set; }

    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Folio autonumérico de la compra o intención de compra
    /// </summary>
    public int Compra { get; set; }

    /// <summary>
    /// fecha de la nueva vigencia de la membresía
    /// </summary>
    public DateTime FechaVigencia { get; set; }

    /// <summary>
    /// Estatus de la membresía del socio al momento de la renovación (enum.EstatusMembresiaSocio)
    /// </summary>
    public int EstatusMembresia { get; set; }

    public virtual Compra CompraNavigation { get; set; } = null!;

    public virtual Socio SocioNavigation { get; set; } = null!;
}
