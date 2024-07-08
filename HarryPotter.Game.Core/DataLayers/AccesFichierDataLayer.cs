using HarryPotter.Games.Core.Interfaces.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Game.Core.DataLayers
{
    public class AccesFichierDataLayer : IDataLayers
    {

        #region Fields
        private readonly string chemniEnregistrement;
        #endregion

        #region Constructors
        public AccesFichierDataLayer(string chemniEnregistrement)
        {
            this.ChemniEnregistrement = chemniEnregistrement;
        }
        #endregion

        #region Public methods

        public void Ecrire(object item)
        {
            if (!File.Exists(ChemniEnregistrement))
            {
                var streamWriter = File.CreateText(this.ChemniEnregistrement);
                streamWriter.Close();
            }
            else
            {
                //ce n'est pas le meme using que dans l'entete de la classe
                //celui la permet d'utiliser proprement les dispose des classes qui en ont. des qu'il y a un dispose on peut utiliser le using
                using FileStream fileStream = File.Open(this.ChemniEnregistrement, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                try
                {
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(item.ToString());

                    fileStream.Write(buffer, 0, buffer.Length);
                    fileStream.Flush();
                }
                //on ferme qd meme au cas ou
                finally
                {
                    fileStream.Close();
                }
            }


            System.IO.File.WriteAllText(this.ChemniEnregistrement, item.ToString());
        }
        #endregion

        #region Properties
        public string ChemniEnregistrement
        {
            get;
            init;
        }
        #endregion
    }
}
