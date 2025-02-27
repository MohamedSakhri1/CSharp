using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2
{
    internal class Dictionnaire : Document
    {
        string langue;
        int nbrMots;

        public Dictionnaire(string langue, int nbrMots, string titre = "sans titre") : base(titre)
        {
            this.langue = langue;
            this.nbrMots = nbrMots;
        }

        public override string Description()
        {

            string fiche;

            fiche = "le titre du Dictionnaire est : " + this.titre + "\n langue est : " + this.langue + " \n contient " + this.nbrMots + " mots .";

            return fiche;


        }

    }
}
