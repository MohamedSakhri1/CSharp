using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.Entities
{
    internal class Eleve : Entity
    {
        private int id;
        private string nom;
        private string prenom;
        private string ville;
        private string specialite;
        private int groupe;

        public Eleve() { }
        public Eleve(int id = 0, string nom = null, string prenom = null, string ville = null, string specialite = null, int groupe = 0)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.specialite = specialite;
            this.groupe = groupe;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Ville { get { return ville; } set { ville = value; } }
        public string Specialite { get { return specialite; } set { specialite = value; } }
        public int Groupe { get { return groupe; } set { groupe = value; } }

    }
}
