using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal abstract class Personnel : Personne
    {
        protected double salaire;
        protected string bureau;
        protected double prime;

        protected Personnel(int code, string nom, string prenom, double salaire = 0, string bureau = "sans bureau", double prime = 0) : base(code, nom, prenom)
        {
            this.salaire = salaire;
            this.bureau = bureau;
            this.prime = prime;
        }

        public abstract double CalculerSalaire();

        protected double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        protected string Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }

    }
}
