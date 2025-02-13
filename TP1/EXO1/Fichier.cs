using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Fichier
    {
        string nom;
        string extension;
        float taille;

        public Fichier(string nom = "", string extension = ".txt", float tailleKO = 0F)
        {
            this.nom = nom;
            this.extension = extension;
            this.taille = tailleKO;
        }

        public string Nom { 
            get { return nom; } 
            set { nom = value; }
        }
        public float TailleKO
        {
            get { return taille; }
            set { taille = value; }
        }
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }


 
    }
}
