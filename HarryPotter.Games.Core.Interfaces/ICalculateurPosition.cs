using HarryPotter.Games.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core.Interfaces
{/// <summary>
/// Contrat de calcul de position
/// </summary>
    public interface ICalculateurPosition
    {
        /// <summary>
        /// Calcul une nouvelle position d'un character donné
        /// </summary>
        /// <returns></returns>
        Position Calculer();
    }
}
