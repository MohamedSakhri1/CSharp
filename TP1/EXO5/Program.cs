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
            try
            {
                Client client = Menu.Login();
                if (client == null)
                    return;

                if (client.Role.Equals(Role.CLIENT))
                {
                    do
                    {
                        var responce = Menu.PrincipaleClient();
                        int responceOperation = 0;

                        switch (responce)
                        {
                            case 0: return;
                            case 1:
                                Menu.AjouterCompte(client);
                                continue;
                            case 2:
                                responceOperation = Menu.OperationsSurCompte(client);
                                break;
                        }

                        switch(responceOperation)
                        {
                            case 0: continue;
                            case 1: Menu.Crediter(client.Compte);
                                continue;
                            case 2: Menu.Debiter(client.Compte);
                                continue;
                            case 3: Menu.Historique(client.Compte);
                                continue;
                            case 4: Menu.Verser(client.Compte);
                                continue;

                        }



                    } while (true);
                    
                } 
                
                else if (client.Role.Equals(Role.ADMIN))
                {
                    var responce = Menu.PrincipaleAdmin();

                    switch (responce)
                    {
                        case 0: return;
                        case 1:
                            Menu.AjouterClient();
                            break;



                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("/!\\ " + ex.Message);
            }

        }

    }
}
