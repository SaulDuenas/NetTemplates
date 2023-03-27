using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Almacena las solicitudes de retiro y lleva control de su validación
/// 
/// Cuando un socio desea hacer un retiro, primero que nada se registra su solicitud en esta tabla y se manda un correo con la clave de validación.
/// Si el socio realiza la validación correctamente, entonces se registra el retiro en la tabla movimientos y se solicita su pago en la tabla pagos
/// </summary>
public partial class SolicitudesRetiro
{
    /// <summary>
    /// folio autonumérico del registro
    /// </summary>
    public int SolicitudRetiro { get; set; }

    /// <summary>
    /// id del plan
    /// </summary>
    public int Plan { get; set; }

    /// <summary>
    /// Fecha y hora de la solicitud de retiro
    /// </summary>
    public DateTime FechaHora { get; set; }

    /// <summary>
    /// Fecha y hora límite en la que se puede realizar la validación de la solicitud
    /// </summary>
    public DateTime Vigencia { get; set; }

    /// <summary>
    /// Monto a retirar
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// clave UUID (autogenerada) que identifica la solicitud y sirve para la autorización del retiro
    /// </summary>
    public Guid ClaveValidacion { get; set; }

    /// <summary>
    /// indica si ya se envió el correo al socio para validar la solicitud
    /// </summary>
    public bool CorreoEnviado { get; set; }

    /// <summary>
    /// indica si el retiro ya fué autorizado por el usuario
    /// </summary>
    public bool Validado { get; set; }

    /// <summary>
    /// Fecha y hora en que el usuario realizó la validación de su solicitud
    /// </summary>
    public DateTime? FechaValidacion { get; set; }

    /// <summary>
    /// Indica si el retiro ya fue procesado para el cálculo de rangos
    /// </summary>
    public bool Procesado { get; set; }

    public virtual SocioProducto PlanNavigation { get; set; } = null!;
}
