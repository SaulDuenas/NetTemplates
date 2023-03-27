using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

/// <summary>
/// Almacena los acumulados de la red de un socio, desglosado por nivel
/// </summary>
public partial class SocioAcumuladoNivel
{
    /// <summary>
    /// Id del socio
    /// </summary>
    public int Socio { get; set; }

    /// <summary>
    /// Nivel de acumulado (1,2,3,...)
    /// </summary>
    public int Nivel { get; set; }

    /// <summary>
    /// id del plan
    /// </summary>
    public int? Plan { get; set; }

    /// <summary>
    /// saldo acumulado en el nivel (Suma de planes del nivel
    /// </summary>
    public decimal SaldoAcumulado { get; set; }

    /// <summary>
    /// Estatus del nivel 0=Abierto, 1=Cerrado, 2=Reabierto
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// Fecha de inicio del acumulado (aprox un mes antes de la fecha de apertura del plan que abre el nivel)
    /// </summary>
    public DateOnly FechaInicio { get; set; }

    /// <summary>
    /// Fecha en que se cierra el nivel (igual a fecha de cierre del plan)
    /// </summary>
    public DateOnly? FechaCierre { get; set; }

    /// <summary>
    /// Fecha limite para reabrir manteniendo la fecha_inicio sin cambio
    /// </summary>
    public DateOnly? FechaLimite { get; set; }

    /// <summary>
    /// id de legacy
    /// </summary>
    public int? IdAux { get; set; }

    public DateTime FechaInsert { get; set; }

    public DateTime FechaUpdate { get; set; }

    public virtual SocioProducto? PlanNavigation { get; set; }

    public virtual Socio SocioNavigation { get; set; } = null!;
}
