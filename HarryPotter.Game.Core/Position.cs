using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class Position
    {
        #region property
        public int X { get; set; }
        public int Y { get; set; }
        #endregion property

        #region constructeurs
        public Position() : this (1,1){ }

        public Position(int x)  : this(x,1) { } 

        public Position(int x, int y) 
        { 
            this.X = x;
            this.Y = y;
        }


        #endregion
    }
}
