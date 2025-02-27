using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal abstract class Personne
    {
        protected int code;
        protected string nom;
        protected string prenom;

        protected Personne(int code, string nom, string prenom)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
        }

        protected int Code
        {
            get { return code; }
            set { code = value; }
        }
        protected string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        protected string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }
}
