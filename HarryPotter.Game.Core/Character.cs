﻿using System;
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

        #endregion property

        #region constructor
        public Character()
        {
            this.Name = string.Empty;
        }

        public Character(string prenom)
        {
            this.Name= prenom;
        }
        #endregion

        #region method public
        public virtual void SeDeplacer()
        {
            Console.WriteLine($"{this.Name} je me déplace");
        }

        public void SeDeplacer( Position newPosition)
        {
            this.SeDeplacer();
            this.CurrentPosition = newPosition;
        }

        public void Attaquer(Character enemy)
        {
            Console.WriteLine("j'attaque {0} ", enemy.Name);
        }
        #endregion

    }
}
