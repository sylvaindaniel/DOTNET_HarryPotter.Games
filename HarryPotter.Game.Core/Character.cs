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
        public Position CurrentPosition { get; set; } = new Position() { X=0 , Y=0};

        protected readonly AfficherInformation afficher;

        #endregion property

        #region constructor
        public Character(AfficherInformation afficher) : this(string.Empty,afficher)
        {
        }

        public Character(string prenom, AfficherInformation afficher)
        {
            this.Name= prenom;
            this.afficher = afficher;

        }
        #endregion

        #region method public
        public virtual void SeDeplacer()
        {
            this.afficher($"{this.Name} je me déplace");
        }

        public void SeDeplacer( Position newPosition)
        {
            this.SeDeplacer();
            this.CurrentPosition = newPosition;
        }

        public void Attaquer(Character enemy)
        {
            this.afficher($"j'attaque {enemy.Name} ");
        }
        #endregion

    }
}
