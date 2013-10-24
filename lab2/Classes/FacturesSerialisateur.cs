using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace lab2.Classes
{
    
    public static class FacturesSerialisateur
    {
        private const string FICHIER_SERIALISATION = "Factures.xml";
        
        public static bool Serialiser(Factures factures)
        {
            
            XmlSerializer xs;

            try
            {
                //Sérialisation des listes
                xs = new XmlSerializer(typeof(Factures));
                using (StreamWriter wr = new StreamWriter(FICHIER_SERIALISATION))
                {
                    xs.Serialize(wr, factures);
                }

                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Factures Deserialiser()
        {
            
            Factures factures = new Factures();
            XmlSerializer xs;

            try
            {
                xs = new XmlSerializer(typeof(Factures));
                using (StreamReader rd = new StreamReader(FICHIER_SERIALISATION))
                {
                    factures = xs.Deserialize(rd) as Factures;
                }

                factures.AjusterCompteurId();

                return factures;
            }
            catch
            {
                //Retour s'il y a eu erreur lors de la désérialisation
                return null;
            }
       
        }
    }
}
