using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class Paise
{
    /// <summary>
    /// Id del país
    /// </summary>
    public int Pais { get; set; }

    /// <summary>
    /// Id del continente
    /// </summary>
    public int Continente { get; set; }

    /// <summary>
    /// nombre del país
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// clave de dos letras del país
    /// </summary>
    public string Countrycode { get; set; } = null!;

    /// <summary>
    /// código telefónico del país
    /// </summary>
    public int Phonecode { get; set; }

    public int PhoneDigits { get; set; }

    public virtual Continente ContinenteNavigation { get; set; } = null!;

    public virtual ICollection<Estado> Estados { get; } = new List<Estado>();

    public virtual ICollection<ZonasHoraria> ZonasHoraria { get; } = new List<ZonasHoraria>();

    public virtual ICollection<Membresia> Membresia { get; } = new List<Membresia>();

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

    public virtual ICollection<Promocione> Promocions { get; } = new List<Promocione>();

    public virtual ICollection<Publicacione> Publicacions { get; } = new List<Publicacione>();
}
