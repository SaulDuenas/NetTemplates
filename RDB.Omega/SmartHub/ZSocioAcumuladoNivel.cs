using System;
using System.Collections.Generic;

namespace RDB.Omega.SmartHub;

public partial class ZSocioAcumuladoNivel
{
    public int Socio { get; set; }

    public int Nivel { get; set; }

    public int? Plan { get; set; }

    public decimal SaldoAcumulado { get; set; }

    public int Estatus { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaLimite { get; set; }

    public int? IdAux { get; set; }
}
