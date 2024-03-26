using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class Force
    {

        #region constructor
        
        public Force() { }
        public Force(ForceType force) 
        {
            this.Type = force;        
        }

        #endregion
        public enum ForceType
        {
            Obscur,
            Lumineux,
            Neutre
        }

        #region property
        public ForceType Type { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return $"Force choisie :{Type}";
        }
        #endregion
    }


}
