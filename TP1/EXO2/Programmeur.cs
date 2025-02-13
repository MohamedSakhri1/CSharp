using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.EXO2
{
    internal class Programmeur
    {
        public static int nbrProgrammeurs = 0;

        int id;
        string nom;
        string prenom;
        int bureau;

        public Programmeur(string nom = "", string prenom = "", int bureau = 0)
        {
            this.id = ++nbrProgrammeurs;
            this.nom = nom;
            this.prenom = prenom;
            this.bureau = bureau;
        }

        public override string ToString()
        {
            return "Nom et Prénom : " + nom +" "+ prenom
                + "\nCode du bureau : " + bureau + "\n";
        }

        public int Id {
            get { return id; } 
            set { id = value; }
        }

        public int Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }
    }
}
