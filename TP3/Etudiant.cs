using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Etudiant : Personne
    {
        private string niveau;
        private double moyenne;

        public Etudiant(int code, string nom, string prenom, string niveau = "sans niveau", double moyenne = 10) : base(code, nom, prenom)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }

    }
}
