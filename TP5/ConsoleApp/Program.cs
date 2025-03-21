using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BiblioDAO;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Eleve eleve = new Eleve(0, "HAMOUCHI", "Mohamed");
                // findAll
                List<object> eleves = eleve.findAll();

                foreach (var item in eleves)
                    Console.WriteLine($"{((Eleve)item).id} - {((Eleve)item).Nom} {((Eleve)item).Prenom}");

                Console.WriteLine($"------ insert ------");
                // insert
                eleve.insert();

                eleves = eleve.findAll();
                foreach (var item in eleves)
                    Console.WriteLine($"{((Eleve)item).id} - {((Eleve)item).Nom} {((Eleve)item).Prenom}");

                Console.WriteLine($"----- update -------");
                // update
                eleve = (Eleve)(eleve.find().First());
                eleve.Nom = "GHAILANI";
                eleve.update();

                eleves = eleve.findAll();
                foreach (var item in eleves)
                    Console.WriteLine($"{((Eleve)item).id} - {((Eleve)item).Nom} {((Eleve)item).Prenom}");

                Console.WriteLine($"----- find -------");
                // find
                eleves = eleve.find();

                foreach (var item in eleves)
                    Console.WriteLine($"{((Eleve)item).id} - {((Eleve)item).Nom} {((Eleve)item).Prenom}");

                Console.WriteLine($"----- delete -------");
                // delete
                eleve.delete();

                eleves = eleve.findAll();
                foreach (var item in eleves)
                    Console.WriteLine($"{((Eleve)item).id} - {((Eleve)item).Nom} {((Eleve)item).Prenom}");

            }
            catch (ReflectionTypeLoadException ex)
            {
                Console.WriteLine("Erreur de chargement des types :");
                foreach (var loaderException in ex.LoaderExceptions)
                {
                    Console.WriteLine(loaderException.Message);
                }
            }
        }
    }
}
