using HarryPotter.Games.core.Models;
using HarryPotter.Games.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class StaticCalculateurPosition : ICalculateurPosition
    {
        #region Fields
        private int x;
        private int y;
        #endregion

        #region Constructeur
        public StaticCalculateurPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Public Methods

        public Position Calculer()
        {
            return new Position
            {
                X = this.x,
                Y = this.y
            };
        }
        #endregion
    }
}
