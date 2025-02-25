using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EXO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client("Sakhri", "Mohamed", "exemple@email.com", "password", Role.CLIENT);
            //client.CreateCompte(2342, 2000);

            Client client = JsonUtils.GetClientById(1);

            //client.Compte.Criditer(1234.55);

            //client.Compte.Debiter(3234);

            //client.Compte.Criditer(100);

            client.Compte.Transactions.ForEach(transaction => {Console.WriteLine(transaction);});

        }
    }
}
