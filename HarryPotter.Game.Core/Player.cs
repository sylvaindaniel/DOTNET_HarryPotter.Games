﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    /// <summary>
    /// Classe qui represente le joueur 
    /// </summary>
    public class Player:Character
    {
        #region constante
        const int DEFAUT_POINT_DE_VIE = 100;
        #endregion
        
        #region properties
        public string Pseudo { get; set; } = "yoda";   //ajoute en plus une valeur par défaut
        public int PointDeVie { get; set; } = DEFAUT_POINT_DE_VIE;

        private DateOnly dateDeNaissance;  //si l'on utilise pas les propriétés dynamiques ci-dessus

        public DateOnly DateDeNaissance { 
            get 
            { 
                return this.dateDeNaissance; 
            }
            set
            {
                this.dateDeNaissance = value;
            }
        }

        public Player() { }
        public Player(string name, string pseudo, DateOnly dateDeNaissance)
        {
            this.Name = name;
            this.Pseudo = pseudo;
            this.DateDeNaissance = dateDeNaissance;
        }
        public Player(string name)
        {
            this.Name = name;
        }
        public Player(string pseudo, string name)
        {
            this.Pseudo = pseudo;
            this.Name = name;
        }
        public Player(string pseudo, DateOnly dateDeNaissance)
        {
            this.Pseudo = pseudo;
            this.DateDeNaissance= dateDeNaissance;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Pseudo: {Pseudo}, Date de naissance: {dateDeNaissance}";
        }
        #endregion properties

        #region Method public
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine($"{this.Name} Cours Forrest !!!!");

        }
        #endregion
    }
}
