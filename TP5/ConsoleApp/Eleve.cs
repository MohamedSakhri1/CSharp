using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioDAO;

namespace ConsoleApp
{
    internal class Eleve : DAO
    {
        private string nom;
        private string prenom;
        private string ville;
        private string specialite;
        private int groupe;

        public Eleve() { }
        public Eleve(int id = 0, string nom = null, string prenom = null, string ville = null, string specialite = null, int groupe = 0) : base(id)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.specialite = specialite;
            this.groupe = groupe;
        }

        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Ville { get { return ville; } set { ville = value; } }
        public string Specialite { get { return specialite; } set { specialite = value; } }
        public int Groupe { get { return groupe; } set { groupe = value; } }

    }
}
