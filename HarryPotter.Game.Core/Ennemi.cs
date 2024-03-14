using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class Ennemi
    {
        #region constante
        const int DEFAUT_POINT_DE_VIE = 100;
        #endregion
        #region method public
        public void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Name} l'ennemi se déplace");
        }

        public void Attaquer(Player player)
        {
            System.Console.WriteLine("l'ennemi attaque le joueur " + player.Pseudo);
        }
        #endregion  method public
        #region property
        public string Name { get; set; }
        public int Force { get; set; }
        public int PointDeVie { get; set; } = DEFAUT_POINT_DE_VIE;
        public Ennemi() { }

        public Ennemi(string name) {
            this.Name = name; 
        }

        public Ennemi(int force) { 
            this.Force = force;
        }

        public Ennemi(string name, int force, int pointDeVie)
        {
            this.Name = name;
            this.Force = force;
            this.PointDeVie = pointDeVie;
        }

        public override string ToString()
        {
           return $"Name: {Name}, Force: {Force}";
        }
        #endregion property

    }
}
