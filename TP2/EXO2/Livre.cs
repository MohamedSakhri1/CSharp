using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2
{
    internal class Livre : Document
    {
        string auteur;
        int nbrPages;

        public Livre(string auteur, int nbrPages, string titre = "sans titre") : base(titre)
        {
            this.auteur = auteur;
            this.nbrPages = nbrPages;
        }

        public override string Description()
        {
            string fiche;

            fiche = "le titre du Livre est : " + this.titre + "\n l'auter est : " + this.auteur + " \n contient " + this.nbrPages + " pages .";

            return fiche;


        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public int NbrPages
        {
            get { return nbrPages; }
            set { nbrPages = value; }

        }

        public int NumEnregistrement
        {
            get { return numEnregistrement; }
            set { numEnregistrement = value; }
        }
    }
}
