using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4
{
    internal class Etudiant
    {
        private double note;
        private int id;

        public Etudiant(double note, int id)
        {
            Note = note;
            this.id = id;
        }

        public double Note
        {
            get { return note; }
            set {
                if (value < 0)
                    throw new ArgumentException("note négative !");
                else if (value > 20)
                    throw new ArgumentException("note supérieur à 20 !");
                note = value;
            }
        }
        public int Id { get { return id; } }
    }
}
