using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// catálogo de estados de cada país
/// </summary>
public partial class Estado
{
    /// <summary>
    /// id del estado
    /// </summary>
    public int Estado1 { get; set; }

    /// <summary>
    /// Id del país
    /// </summary>
    public int Pais { get; set; }

    /// <summary>
    /// nombre del estado
    /// </summary>
    public string Nombre { get; set; } = null!;

    public virtual Paise PaisNavigation { get; set; } = null!;

    public virtual ICollection<ProspectoInfo> ProspectoInfos { get; } = new List<ProspectoInfo>();

    public virtual ICollection<SocioBeneficiario> SocioBeneficiarios { get; } = new List<SocioBeneficiario>();

    public virtual ICollection<SocioInfo> SocioInfos { get; } = new List<SocioInfo>();
}
