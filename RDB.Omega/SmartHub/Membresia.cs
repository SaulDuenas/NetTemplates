using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class Membresia
{
    /// <summary>
    /// Id autonumérico de la membresía
    /// </summary>
    public int Membresia1 { get; set; }

    /// <summary>
    /// id autonumérico del producto 
    /// </summary>
    public int Producto { get; set; }

    /// <summary>
    /// Tipo de Membresía (1=Básica, 2=Premium) (Enum TipoMembresia)
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    /// nombre de la membresía
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// precio de la membresía
    /// </summary>
    public decimal Precio { get; set; }

    /// <summary>
    /// moneda de la membresía
    /// </summary>
    public string Moneda { get; set; } = null!;

    /// <summary>
    /// vigencia en años de la memebresía (0=Vitalicia) (Viene de microcatálogo VigenciaMembresia)
    /// </summary>
    public int Vigencia { get; set; }

    /// <summary>
    /// fecha de inicio de vigencia (a partir de cuando se puede comprar)
    /// </summary>
    public DateTime FechaIni { get; set; }

    /// <summary>
    /// fecha determinación de vigencia (cuando se dejó de vender)
    /// </summary>
    public DateTime? FechaFin { get; set; }

    /// <summary>
    /// se puede pagar en bitcoins
    /// </summary>
    public bool PagoBtc { get; set; }

    /// <summary>
    /// se puede pagar con tarjeta de crédito o débito
    /// </summary>
    public bool PagoTdc { get; set; }

    /// <summary>
    /// descripción libre de la membresía
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// indica si la membresía está activa (se puede vender)
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// Indica si es un borrador (se puede editar libremente)
    /// </summary>
    public bool EsBorrador { get; set; }

    public virtual ICollection<Paquete> Paquetes { get; } = new List<Paquete>();

    public virtual Producto ProductoNavigation { get; set; } = null!;

    public virtual ICollection<PromoMembresia> PromoMembresia { get; } = new List<PromoMembresia>();

    public virtual ICollection<Socio> Socios { get; } = new List<Socio>();

    public virtual ICollection<Paise> Pais { get; } = new List<Paise>();
}
