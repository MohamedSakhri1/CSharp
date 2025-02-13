using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.EXO2
{
    internal class ConsomationCafe
    {
        int numSemaine;
        int programmeurId;
        int nbrTasses;

        public ConsomationCafe(int numSemaine = 1, int programmeurId = 0, int nbrTasses = 0)
        {
            if (numSemaine <= 0)
                this.numSemaine = numSemaine;
            else
                this.numSemaine = 1;

            if (programmeurId <= Programmeur.nbrProgrammeurs)
                this.programmeurId = programmeurId;
            else
                this.programmeurId = 0;

            if (nbrTasses < 0)
                this.nbrTasses = nbrTasses;
            else
                this.nbrTasses = 0;
        }

        public int NumSemaine { 
            get { return numSemaine; }
            set { numSemaine = value; }
        }
        public int ProgrammeurId {
            get { return programmeurId; }
            set { programmeurId = value; }
        }
        public int NbrTasses
        {
            get { return nbrTasses; }
            set { nbrTasses = value; }
        }

        

    }
}
