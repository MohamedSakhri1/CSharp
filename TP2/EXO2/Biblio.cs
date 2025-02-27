using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2
{
    internal class Biblio
    {
        List<Document> documents;

        public Biblio()
        {
            this.documents = new List<Document>();
        }

        public void AddDoc(Document doc)
        {
            if (doc != null) documents.Add(doc);
            else throw new Exception("aucun document n'est envoye");
        }

        public int CalculerNbrLivres()
        {
            int nbrLivres = 0;

            foreach (Document doc in documents)
            {
                if (doc != null)
                {
                    if (doc is Livre)
                        nbrLivres++;
                }

            }
            return nbrLivres;

        }

        public void AfficherDictio()
        {
            foreach (Document doc in documents)
            {
                if (doc != null)
                {
                    if (doc is Dictionnaire)
                    {
                        Console.WriteLine(doc.Description());
                        Console.WriteLine("\n");

                    }
                }

            }

        }

        public void toutesLesDescriptions()
        {
            foreach (Document doc in documents)
            {
                if (doc != null)
                {
                    if (doc is Livre)
                    {
                        Livre livre = (Livre)doc;
                        Console.WriteLine("numero document : " + livre.NumEnregistrement + "l'auteur : " + livre.Auteur);
                        Console.WriteLine("\n");

                    }
                }

            }


        }

    }
}
