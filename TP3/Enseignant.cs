using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Enseignant : Personnel
    {
        private static List<string> gradesDisponible = new List<string> { "PA", "PH", "PES" };

        private int heuresSupplementaire;
        private string grade;
        private int volumeHoraire;
        private Dictionary<string, List<Etudiant>> groupesEtudiants;
        


        public Enseignant(int code, string nom, string prenom, double salaire = 0, string bureau = "sans bureau", string grade = null, int volumeHoraire = 0, int horairesSupplementaire = 0) : base(code, nom, prenom, salaire, bureau)
        {
            this.heuresSupplementaire = horairesSupplementaire;
            Grade = grade;
            this.volumeHoraire = volumeHoraire;
            groupesEtudiants = new Dictionary<string, List<Etudiant>>();
        }


        public override double CalculerSalaire()
        {
            if (grade == null)
                throw new Exception("Sans grade !");

            double coutGrade = 0;
            switch (grade)
            {
                case "PA":
                    coutGrade = 300;
                    break;
                case "PH":
                    coutGrade = 350;
                    break;
                case "PES":
                    coutGrade = 400;
                    break;
                default: 
                    throw new Exception("Grade non prise en charge !");
            }

            return salaire + (volumeHoraire + heuresSupplementaire) * coutGrade;
        }

        public void AjouterGroupe(Groupe groupe) {
            groupesEtudiants.Add(groupe.Nom, groupe.Etudiants);
        }

        public override string ToString()
        {
            return "Enseignant de code : " + code + "\n" ;
        }

        public string Grade
        {
            get { return this.grade; }
            set
            {
                if (gradesDisponible.Contains(value))
                    this.grade = value;
                else
                    throw new Exception("Grade non prise en charge !");
            }
        }
    }
}
