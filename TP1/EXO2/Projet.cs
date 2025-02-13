using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.EXO2
{
    internal class Projet
    {
        int code;
        string sujet;
        int dureeEnSemaine;
        int nombreProgrammeurs;
        List<ConsomationCafe> listDesConsomations;
        List<Programmeur> programmeurs;

        public Projet(int code = 0, string sujet = "", int dureeEnSemaine = 0, int nombreProgrammeurs = 0)
        {
            this.code = code;
            this.sujet = sujet;
            this.dureeEnSemaine = dureeEnSemaine;
            this.nombreProgrammeurs = nombreProgrammeurs;

            listDesConsomations = new List<ConsomationCafe>();
            programmeurs = new List<Programmeur>();
        }

        public int NombreProgrammeurs
        {
            get { return nombreProgrammeurs; }
            set { nombreProgrammeurs = value; }
        }
        public string Sujet
        {
            get { return sujet; }
            set { sujet = value; }
        }
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public int DureeEnSemaine
        {
            get { return dureeEnSemaine; }
            set { dureeEnSemaine = value; }
        }

        public void AjouterProgrammeur(Programmeur programmeur, int numeroSemaineDebut, int nombreTasses)
        {
            if (programmeur == null)
                return;
            programmeurs.Add(programmeur);
            listDesConsomations.Add(new ConsomationCafe(numeroSemaineDebut, programmeur.Id, nombreTasses));
            nombreProgrammeurs++;
        }

        public Programmeur RechercherProgrammeur(int programmeurId)
        {
            for (int i = 0; i < programmeurs.Count; i++)
            {
                Programmeur programmeur = programmeurs[i];
                if (programmeur.Id == programmeurId)
                    return programmeur;
            }
            return null;
        }
        public void SupprimmerProgrammeur(int programmeurId)
        {
            Programmeur programmeur = RechercherProgrammeur(programmeurId);
            if (programmeur == null) return;

            programmeurs.Remove(programmeur);
        }

        public void AfichierProgrammeur(int programmeurId)
        {
            Programmeur programmeur = RechercherProgrammeur(programmeurId);
            if (programmeur == null) return;

            System.Console.WriteLine(programmeur);
        }
        public void AffichierProgrammeurs() {

            foreach (var item in programmeurs)
            {
                System.Console.WriteLine(item);
            }

        }

        public ConsomationCafe GetConsomationByProgrammeur(int programmeurId)
        {
            foreach (var item in listDesConsomations)
            {
                if(item.ProgrammeurId == programmeurId) return item;
            }
            return null;
        }

        public void AjouterConsommationProgrammeur(int programmeurId, int nbrTassesNouvelles)
        {
            ConsomationCafe consomationCafe = GetConsomationByProgrammeur(programmeurId);
            if (consomationCafe == null) return;

            consomationCafe.NbrTasses = consomationCafe.NbrTasses + nbrTassesNouvelles;
        }

        public void ChangerBureauProgrammeur(int programmeurId, int nouveauBureau)
        {
            Programmeur programmeur = RechercherProgrammeur(programmeurId);
            if (programmeur == null || nouveauBureau <= 0) return;

            programmeur.Bureau = nouveauBureau;
        }

        public int getNbrTotalTasses()
        {
            int total = 0;
            foreach (var item in listDesConsomations)
            {
                total += item.NbrTasses;
            }
            return total;
        }

    }
}
