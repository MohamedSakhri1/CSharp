using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Document> Docs = new List<Document>();

            Docs.Add(new Livre("Ghailani Mohamed", 76543, "intro to csharp"));
            Docs.Add(new Dictionnaire("Darija", 76743, "Fahras"));

            Docs.ForEach(doc => Console.WriteLine(doc.Description()));
        }
    }
}
