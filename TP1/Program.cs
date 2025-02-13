using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXO 1
            Repertoire repertoire = new Repertoire("reprtoire de test");
            repertoire[0] = new Fichier("fichier_pdf","pdf",234F);
            repertoire.Afficher();
            float talleRepo = repertoire.getTaille();
            System.Console.WriteLine(talleRepo + " Mo");

            // EXO 2

        }
    }
}
