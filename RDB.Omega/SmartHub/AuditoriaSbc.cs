using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Tabla con el log de auditoría de las acciones que se realiza en el sitio de administración
/// </summary>
public partial class AuditoriaSbc
{
    /// <summary>
    /// Folio autonumérico del registro
    /// </summary>
    public int Folio { get; set; }

    /// <summary>
    /// fecha y hora 
    /// </summary>
    public DateTime FechaHora { get; set; }

    /// <summary>
    /// Usuario de SBC que realiza la acción
    /// </summary>
    public string Usuario { get; set; } = null!;

    /// <summary>
    /// Acción que realiza el usuario (Enum A1_Acciones)
    /// </summary>
    public int Accion { get; set; }

    /// <summary>
    /// Módulo desde el que realiza la acción (Enum A1_Modulos)
    /// </summary>
    public int Modulo { get; set; }

    /// <summary>
    /// Tipo de objeto creado o modificado (Enum Au_TipoObjeto)
    /// </summary>
    public int? TipoObjeto { get; set; }

    /// <summary>
    /// Id del registro del objeto en cuestión
    /// </summary>
    public int? Objeto { get; set; }

    /// <summary>
    /// Identificación alterna del objeto (en caso de que el ID sea texto)
    /// </summary>
    public string? Elemento { get; set; }

    /// <summary>
    /// Valor nuevo que toma el elemento o propiedad
    /// </summary>
    public string? Valor { get; set; }

    /// <summary>
    /// Descripción de la acción que realiza el usuario
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// Detalle de la acción que realiza el usuario (Ver Notas)
    /// </summary>
    public string? Detalle { get; set; }

    public string? ValorAnterior { get; set; }
}
