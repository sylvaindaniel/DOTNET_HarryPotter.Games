using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class Character
    {
         /// <summary>
        /// Classe parente
        /// </summary>
        /// 
        #region property
        public string Name { get; set; }
        #endregion property

        #region method public
        public virtual void SeDeplacer()
        {
            Console.WriteLine($"{this.Name} je me déplace");
        }
        public void Attaquer(Character enemy)
        {
            Console.WriteLine("j'attaque {0} ", enemy.Name);
        }
        #endregion

    }
}
