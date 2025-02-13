using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Repertoire
    {
        string nom;
        int nbrFichiers;
        List<Fichier> fichiers;

        public Repertoire(string nom = "")
        {
            this.nom = nom;
            this.nbrFichiers = 0;
            fichiers = new List<Fichier>();
            
        }
        public Fichier this[int index]
        {
            get { return fichiers[index]; }
            set { fichiers.Add(value); }
        }
        public int NbrFichiers
        {
            get { return nbrFichiers; }
            set { nbrFichiers = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public void Afficher()
        {
            System.Console.WriteLine("nom du repertoire :" + nom);
        }

        public int Rechercher(string nom)
        {
            for (int i = 0; i < nbrFichiers; i++)
            {
                Fichier fichier = fichiers[i];
                if (fichier.Nom == nom)
                    return i;
            }
            return -1;
        }

        public void Supprimer(string nomFichier)
        {
            int indexDuFichier = this.Rechercher(nomFichier);
            Fichier fichier = fichiers[indexDuFichier];
            if (fichier != null && fichier.Extension.Equals("pdf"))
                fichiers.Remove(fichier);
        }

        public void Renommer(int indexFichier ,string nouveauNom)
        {
            Fichier fichier = fichiers[indexFichier];
            if (fichier != null) fichier.Nom = nouveauNom;
        }

        public void Modifier(int indexFichier, float nouvelleTalle)
        {
            Fichier fichier = fichiers[indexFichier];
            if (fichier != null) fichier.TailleKO = nouvelleTalle;
        }

        public float getTaille()
        {
            float talleRepoMO = 0.0f;
            foreach (Fichier fichier in fichiers)
            {
                talleRepoMO += fichier.TailleKO / 1000;
            }

            return talleRepoMO;
        }


    }
}
