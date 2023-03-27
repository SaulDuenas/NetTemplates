using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Lista de correos por enviar/enviados
/// </summary>
public partial class Correo
{
    /// <summary>
    /// Id autonumérico
    /// </summary>
    public int Folio { get; set; }

    public int? Socio { get; set; }

    public string? Direccion { get; set; }

    /// <summary>
    /// tipo de evento que desencadena el correo
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// id del retiro, compra, bono, prospecto,  o elemento en cuestión
    /// </summary>
    public int Referencia { get; set; }

    /// <summary>
    /// otro dato
    /// </summary>
    public string? Auxiliar { get; set; }

    /// <summary>
    /// 0=Sin enviar, 1=enviado, 2=cancelado (por muchos intentos)
    /// </summary>
    public int Estatus { get; set; }

    public int Intento { get; set; }

    public string? Asunto { get; set; }

    public string? Cuerpo { get; set; }

    /// <summary>
    /// fecha de envío
    /// </summary>
    public DateTime? FechaEnviado { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }
}
