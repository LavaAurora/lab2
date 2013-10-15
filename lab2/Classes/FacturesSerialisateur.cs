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

        private const string FICHIER_CABLE = "FactureCable.xml";
        private const string FICHIER_EPICERIE = "FactureEpicerie.xml";
        private const string FICHIER_UNIVERSITE = "FactureUniversite.xml";

        /*
        public static bool Serialiser (Factures factures)
        {
            //Listes des factures (on ne peut sérialiser à partir de la 
            //classe abstraite Factures)
            List<FactureCable> lCable = new List<FactureCable>();
            List<FactureEpicerie> lEpicerie = new List<FactureEpicerie>();
            List<FactureUniversite> lUniversite = new List<FactureUniversite>();
            XmlSerializer xs;

            //Sépare les factures contenues dans le système en fonction de leur type
            foreach(Facture f in factures.ListeFactures)
            {
                if (f.GetType() == typeof(FactureCable))
                {
                    lCable.Add((FactureCable)f);
                }
                else if (f.GetType() == typeof(FactureEpicerie))
                {
                    lEpicerie.Add((FactureEpicerie)f);
                }
                else if (f.GetType() == typeof(FactureUniversite))
                {
                    lUniversite.Add((FactureUniversite)f);
                }
            }
            
            try
            {
                //Sérialisation des listes
                xs = new XmlSerializer(typeof(List<FactureCable>));
                using (StreamWriter wr = new StreamWriter(FICHIER_CABLE))
                {
                    xs.Serialize(wr, lCable);
                }


                xs = new XmlSerializer(typeof(List<FactureEpicerie>));
                using (StreamWriter wr = new StreamWriter(FICHIER_EPICERIE))
                {
                    xs.Serialize(wr, lEpicerie);
                }

                xs = new XmlSerializer(typeof(List<FactureUniversite>));
                using (StreamWriter wr = new StreamWriter(FICHIER_UNIVERSITE))
                {
                    xs.Serialize(wr, lUniversite);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Facture> Deserialiser()
        {
            
            List<Facture> lFacture = new List<Facture>();
            XmlSerializer xs;

            try
            {
                xs = new XmlSerializer(typeof(List<FactureCable>));
                using (StreamReader rd = new StreamReader(FICHIER_CABLE))
                {
                    lFacture.AddRange(xs.Deserialize(rd) as List<FactureCable>);
                }

                xs = new XmlSerializer(typeof(List<FactureEpicerie>));
                using (StreamReader rd = new StreamReader(FICHIER_EPICERIE))
                {
                    lFacture.AddRange(xs.Deserialize(rd) as List<FactureEpicerie>);
                }

                xs = new XmlSerializer(typeof(List<FactureUniversite>));
                using (StreamReader rd = new StreamReader(FICHIER_UNIVERSITE))
                {
                    lFacture.AddRange(xs.Deserialize(rd) as List<FactureUniversite>);
                }


                return lFacture;
            }
            catch
            {
                //Retour s'il y a eu erreur lors de la désérialisation
                return null;
            }
        }
         */

        public static bool Serialiser(Factures factures)
        {
            //Listes des factures (on ne peut sérialiser à partir de la 
            //classe abstraite Factures)
            //List<FactureCable> lCable = new List<FactureCable>();
            //List<FactureEpicerie> lEpicerie = new List<FactureEpicerie>();
            //List<FactureUniversite> lUniversite = new List<FactureUniversite>();
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
