using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Ecole.Dao;

namespace Gestion_Ecole.Entities
{
    internal class Absence : Entity
    {
        private int id;
        private int id_eleve;
        private int numero_semaine;
        private int nbr_absences;

        public Absence() { }
        public Absence(int idEleve = 0, int numeroSemaine = 0, int nbrAbsences = 0)
        {
            this.id_eleve = idEleve;
            this.numero_semaine = numeroSemaine;
            this.nbr_absences = nbrAbsences;
        }

        public int Id { get { return id; } set { id = value; } }
        public int Id_Eleve { get { return id_eleve; } set { id_eleve = value; } }
        public int Numero_Semaine { get { return numero_semaine; } set { numero_semaine = value; } }
        public int Nbr_Absences { get { return nbr_absences; } set { nbr_absences = value; } }

    }
}
