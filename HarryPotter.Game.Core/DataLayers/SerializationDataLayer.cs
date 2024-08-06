using HarryPotter.Games.Core.Interfaces.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HarryPotter.Game.Core.DataLayers
{
    public class SerializationDataLayer<T> : IDataLayers<T> where T:class
    {

        #region Constructors
        public SerializationDataLayer() { }

        public SerializationDataLayer(string cheminEnregistrement)
        {
            this.CheminEnregistrement = cheminEnregistrement;
        }
        #endregion

        #region Public methods
        public void Ecrire(T item)
        {
            //Type toto = item.GetType();
            

            //GetType permet de retrouver le type de l'objet passé (ici c'est Menu)
            XmlSerializer serializer = new XmlSerializer(item.GetType());



            using FileStream? fileStream = new FileStream(this.CheminEnregistrement, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            serializer.Serialize(fileStream, item);
        }

        public T Lire(Type typeObjet)
        {
            XmlSerializer serializer = new XmlSerializer(typeObjet);

            using FileStream? fileStream = new FileStream(this.CheminEnregistrement, FileMode.OpenOrCreate, FileAccess.Read);

            return serializer.Deserialize(fileStream) as T;


        }
        #endregion


        #region Properties
        public string CheminEnregistrement
        {
            get;
            init;
        }
        #endregion
    }
}
