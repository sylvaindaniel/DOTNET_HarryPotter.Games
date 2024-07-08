using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core.Interfaces.DataLayers
{
    /// <summary>
    /// Contrat d'accès à une base de données
    /// </summary>
    public interface IDataLayers
    {
        /// <summary>
        /// Ecrire dans un fichier
        /// </summary>
        /// <param name="item"></param>
        void Ecrire(object item);
    }
}
