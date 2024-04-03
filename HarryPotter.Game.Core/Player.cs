using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Game.Core.Force;

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

        public Force Force { get; set; }

        private DateOnly dateDeNaissance;  //si l'on utilise pas les propriétés dynamiques ci-dessus

        public DateOnly DateDeNaissance
        {
            get
            {
                return this.dateDeNaissance;
            }
            set
            {
                this.dateDeNaissance = value;
            }
        }


        public override string ToString()
        {
            string forceMessage = (Force == null || Force.Type == ForceType.Neutre) ? "tu n'as pas encore choisi ton camp !" : $"tu as choisie le côté {Force.Type} de la force";
            return $"Name: {Name}, Pseudo: {Pseudo}, Date de naissance: {dateDeNaissance}, {forceMessage}";
        }
        #endregion properties

        #region constructor
        public Player(string name, string pseudo, DateOnly dateDeNaissance, Force force,AfficherInformation afficher) : base(name, afficher)
        {
            this.Pseudo = pseudo;
            this.DateDeNaissance = dateDeNaissance;
            this.Force = force;
        }
        public Player(AfficherInformation afficher) : this(string.Empty,string.Empty,DateOnly.MinValue, new Force(ForceType.Neutre),afficher)
        {            
        }
        public Player(string name, AfficherInformation afficher) : this(name, string.Empty, DateOnly.MinValue, new Force(ForceType.Neutre),afficher)
        {
        }
        public Player(string name, string pseudo,AfficherInformation afficher) : this(name, pseudo, DateOnly.MinValue, new Force(ForceType.Neutre), afficher)
        {
        }
        public Player(string pseudo, DateOnly dateDeNaissance,AfficherInformation afficher) : this(string.Empty, pseudo, dateDeNaissance, new Force(ForceType.Neutre), afficher)
        {
        }
        #endregion

        

        #region Method public
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            this.afficher($"{this.Name} Cours Forrest !!!!");

        }

        #endregion
    }
}
