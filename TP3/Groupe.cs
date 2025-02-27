using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Groupe
    {
        private string nom;
        private List<Etudiant> etudiants;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<Etudiant> Etudiants
        {
            get { return etudiants; }
            set { etudiants = value; }
        }
    }
}
