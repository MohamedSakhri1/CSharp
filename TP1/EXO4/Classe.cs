using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4
{
    internal class Classe
    {
        private int talle;
        private List<Etudiant> etudiants;

        public Classe(int talle = 1)
        {
            Talle = talle;
            etudiants = new List<Etudiant>();
        }

        public int Talle { 
            get { return talle; }
            set {
                if (value < 0)
                    throw new Exception("Taille négative !");
                if (value == 0)
                    throw new Exception("Taille vide !");

                talle = value; 
            }
        }
        public List<Etudiant> Etudiants { get { return etudiants; } }

        public void Ajouter(double note)
        {
            if (etudiants.Count == talle)
                throw new Exception("Talle maximale attainte !");

            int nextIndex = etudiants.Count;
            Etudiant etud = new Etudiant(note, nextIndex);

            etudiants.Add(etud);
        }

        public double NoteMax()
        {
            double leMax = etudiants[0].Note;

            foreach (Etudiant etudiant in etudiants)
            {
                if(leMax < etudiant.Note)
                    leMax = etudiant.Note;
            }
            return leMax;
        }

        public double NoteMin()
        {
            double leMin = etudiants[0].Note;

            foreach (Etudiant etudiant in etudiants)
            {
                if (leMin > etudiant.Note)
                    leMin = etudiant.Note;
            }
            return leMin;
        }

        public double NoteMoyenne()
        {
            double moyenne = 0;

            foreach (Etudiant etudiant in etudiants)
            {
                moyenne += etudiant.Note/talle;
            }

            return moyenne;
        }

        public bool isFull()
        {
            return etudiants != null && etudiants.Count == talle;
        }

    }
}
