using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Ecole.Entities;

namespace Gestion_Ecole.Dao
{
    internal class AbsenceDAO : DAO<Absence>
    {
        public AbsenceDAO() : base() { }

        public List<Absence> getEleveAbsences(Eleve eleve)
        {
            List<Absence> list = new List<Absence>();

            foreach (Absence item in this.findAll()) {
                if (item.Id_Eleve.Equals(eleve.Id))
                    list.Add(item);
            }
            return list;
        }

        public int getEleveTotalAbs(Eleve eleve)
        {
            List<Absence> list = getEleveAbsences(eleve);

            int totalAbs = 0;
            foreach(Absence absence in list)
            {
                totalAbs += absence.Nbr_Absences;
            }

            return totalAbs;
        }
    }

}
