using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Categorías de la publicación
/// </summary>
public partial class PubCateg
{
    /// <summary>
    /// Id autonumérico de la publicación
    /// </summary>
    public int Publicacion { get; set; }

    /// <summary>
    /// Id de la categoría (Enum: CategPublicacion)
    /// </summary>
    public int Categoria { get; set; }

    public virtual Publicacione PublicacionNavigation { get; set; } = null!;
}
