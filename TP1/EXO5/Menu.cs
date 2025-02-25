using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXO5;


internal static class Menu
{
    public static int PrincipaleClient()
    {
        do
        {
            Console.WriteLine("====================================");
            Console.WriteLine("1) Ajouter un nouveau compte");
            Console.WriteLine("2) Operation sur compte");
            Console.WriteLine("0) Quitter le programme");
            Console.WriteLine("====================================");
            var responce = ReadResponce();

            if (responce < 0 || responce > 2)
                Console.WriteLine("\n/!\\ Choix hors [0 - 2] !\n");
            else
                return responce;
        }
        while ( true );
    }

    public static int PrincipaleAdmin()
    {
        do
        {
            Console.WriteLine("====================================");
            Console.WriteLine("1) Ajouter un nouveau client");
            Console.WriteLine("2) Rechercher un compte");
            Console.WriteLine("3) Afficher tous les comptes");
            Console.WriteLine("0) Quitter le programme");
            Console.WriteLine("====================================");
            var responce = ReadResponce();

            if (responce < 1 || responce > 4)
                Console.WriteLine("\n/!\\ Choix hors [0 - 3] !\n");
            else
                return responce;
        }
        while (true);
    }

    public static void AjouterCompte(Client client)
    {
        Console.Write("Entrez le num du compte : ");
        var numeroCompte = Console.ReadLine();

        Console.Write("Entrez le solde initial : ");
        var soldeInitial = Console.ReadLine();

        client.CreateCompte(int.Parse(numeroCompte), int.Parse(soldeInitial));
    }

    public static int OperationsSurCompte(Client client)
    {
        do
        {
            Console.WriteLine("======== OPERATIONS SUR COMPTE : "+ client.Compte.Numero +" ========");
            Console.WriteLine("1) Crediter");
            Console.WriteLine("2) Debiter");
            Console.WriteLine("3) Historique");
            Console.WriteLine("4) Versement d'argent");
            Console.WriteLine("0) Retour au menu principale");
            Console.WriteLine("===================================================");
            var responce = ReadResponce();

            if (responce < 0 || responce > 4)
                Console.WriteLine("\n/!\\ Choix hors [0 - 4] !\n");
            else
                return responce;

        } while (true);
    }

    public static void Crediter(Compte compte)
    {
        do
        {
            Console.Write("Entrez la somme a crediter : ");
            var montant = double.Parse(Console.ReadLine());

            try
            {
                compte.Crediter(montant);
                return;

            } catch (Exception ex) 
            {
                Console.WriteLine("\n/!\\ " + ex.Message); 
            }

        } while (true);

    }
    public static void Debiter(Compte compte)
    {
        do
        {
            Console.Write("Entrez la somme a debiter : ");
            var montant = double.Parse(Console.ReadLine());

            try
            {
                compte.Debiter(montant);
                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n/!\\ " + ex.Message);
            }

        } while (true);

    }
    public static void Historique(Compte compte)
    {
        compte.Transactions.ForEach(t => { Console.WriteLine(t.ToString()); });
    }
    public static void Verser(Compte compte)
    {
        do
        {
            try
            {
                Console.Write("Entrer la somme a verser : ");
                var montant = double.Parse(Console.ReadLine());
                Console.Write("Entrer le numero du compte recepteur :");
                var numeroCompte = int.Parse(Console.ReadLine());

                compte.Verser(montant, numeroCompte);
                return;

            } catch (Exception ex) { Console.WriteLine("\n/!\\ " + ex.Message); }
        } while (true);

    }

    public static void AjouterClient()
    {
        Console.Write("Entrez le Nom du client : ");
        var nom = Console.ReadLine();
        Console.Write("Entrez le prenom du client : ");
        var prenom = Console.ReadLine();
        Console.Write("Entrez le mail du client " + nom + " : ");
        var mail = Console.ReadLine();
        Console.Write("Entrez le mot du pass : ");
        var password = Console.ReadLine();

        Client client = new Client(nom, prenom, mail, password);
    }

    public static int ReadResponce()
    {
        Console.Write("Donnez votre choix: ");

        string responceString = Console.ReadLine();
        return int.Parse(responceString);
    }

    public static Client Login()
    {
        string username;
        string password;
        Console.Write("Username/email :");
        username = Console.ReadLine();

        Console.Write("Password :");
        password = Console.ReadLine();

        Client client = JsonUtils.GetClientByMail(username);
        if (client == null || client.Password != password)
        {
            Console.WriteLine("\nAcces non autorisé !");
            return null;
        }

        return client;
    }

        
}