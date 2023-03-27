using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// tabla de registro de la wallet del socio
/// (sólo puede tener UNA ACTIVA)
/// </summary>
public partial class SocioWallet
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Número de wallet del socio (solo una puede estar activa)
    /// </summary>
    public int NumWallet { get; set; }

    /// <summary>
    /// clave de tipo de criptomoneda (de microcatálogo)
    /// </summary>
    public int Criptomoneda { get; set; }

    /// <summary>
    /// clave de wallet
    /// </summary>
    public string Wallet { get; set; } = null!;

    public bool Activa { get; set; }

    /// <summary>
    /// Fecha de Registro de la wallet
    /// </summary>
    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    /// <summary>
    /// Bandera para verificar si el wallet ha sido validado
    /// </summary>
    public bool? Validado { get; set; }

    /// <summary>
    /// Fecha de validacion
    /// </summary>
    public DateOnly? FechaValidacion { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
