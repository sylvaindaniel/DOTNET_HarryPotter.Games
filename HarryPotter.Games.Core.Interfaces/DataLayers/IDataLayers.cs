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
    public interface IDataLayers<Titem1> : IEcrireData<Titem1>, ILireData<Titem1> where Titem1 : class
    {

    }
}
