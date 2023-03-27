using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// catálogo de premios en especie
/// (un iPhone, un peluche, una taza, una TV, un viaje)
/// </summary>
public partial class Premio
{
    /// <summary>
    /// Id autonumérico del premio
    /// </summary>
    public int Premio1 { get; set; }

    /// <summary>
    /// nombre del premio
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del premio
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// Nombre del archivo con la foto del producto
    /// </summary>
    public string? Foto { get; set; }

    /// <summary>
    /// Nombre del archivo anexo con la descripción del premio
    /// (Folleto en PDF o similar)
    /// </summary>
    public string? Anexo { get; set; }

    public virtual ICollection<Promocione> Promociones { get; } = new List<Promocione>();
}
