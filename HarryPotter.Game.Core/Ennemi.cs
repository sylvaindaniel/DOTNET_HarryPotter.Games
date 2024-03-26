using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core
{
    public class Ennemi:Character
    {
        #region constante
        const int DEFAUT_POINT_DE_VIE = 100;
        #endregion
 
        #region property
        public int Force { get; set; }
        public int PointDeVie { get; set; } = DEFAUT_POINT_DE_VIE;

        #region constructor
        public Ennemi(string name, int force, int pointDeVie) : base(name) 
        {
            this.Force = force;
            this.PointDeVie = pointDeVie;
        }
        public Ennemi() : this(string.Empty,default,default) 
        {
        }
        public Ennemi(string name) : this(name,default,default)
        {
        }

        public Ennemi(int force) :this(string.Empty,default,default)
        { 
        }

        #endregion
        public override string ToString()
        {
           return $"Name: {Name}, Force: {Force}";
        }
        #endregion property

        #region Method public
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine($"{this.Name} Je saute de bond en bond !! bouing bouing bouing !!!!");

        }
        #endregion

    }
}
