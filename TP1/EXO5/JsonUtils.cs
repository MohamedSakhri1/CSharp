using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using EXO5;

internal static class JsonUtils
{
    public static string USERS_JSON_PATH = "D:\\Mohamed\\Mohamed\\C#\\TPs\\TP1\\EXO5\\users.json";
    public static string COMPTES_JSON_PATH = "D:\\Mohamed\\Mohamed\\C#\\TPs\\TP1\\EXO5\\comptes.json";


    public static string ToJson(object obj)
    {
        var json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        return json;
    }
    public static void FillFile(string json, string filePath)
    {
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, json);
        }
    }

    public static List<Client> GetClients()
    {
        if (!File.Exists(USERS_JSON_PATH))
            return new List<Client>();

        string json = File.ReadAllText(USERS_JSON_PATH);
        if (json.Equals(string.Empty))
            return new List<Client>();
        return JsonSerializer.Deserialize<List<Client>>(json);
    }

    public static Client GetClientById(int id)
    {
        var clients = GetClients();
        var myClient =  clients.FirstOrDefault(client => client.Id == id);
        myClient.Compte = GetUserCompte(myClient.Id);

        return myClient;
    }
    public static void StoreClient(Client client)
    {
        List<Client> clients = GetClients();
        clients.Add(client);

        FillFile(ToJson(clients), USERS_JSON_PATH);
    }


    public static List<Compte> GetComptes()
    {
        if (!File.Exists(COMPTES_JSON_PATH))
            return new List<Compte>();

        var json = File.ReadAllText(COMPTES_JSON_PATH);
        if (json.Equals(string.Empty))
            return new List<Compte>();

        return JsonSerializer.Deserialize<List<Compte>>(json);
    }
    public static Compte GetUserCompte(int idClient)
    {
        var comptes = GetComptes();
        return comptes.FirstOrDefault(compte => compte.ClientId == idClient);
    }

    public static void StoreCompte(Compte compte)
    {
        List<Compte> comptes = GetComptes();
        comptes.Add(compte);

        FillFile(ToJson(comptes), COMPTES_JSON_PATH);
    }

    public static void UpdateCompte(int compteNumero, Compte newCompte)
    {
        var comptes = GetComptes();
        Compte oldCompte = comptes.FirstOrDefault(compte => compte.Numero == compteNumero);

        if (oldCompte != null)
        {
            comptes.Remove(oldCompte);

            newCompte.Numero = compteNumero;
            newCompte.ClientId = oldCompte.ClientId;

            oldCompte = newCompte;

            comptes.Add(newCompte);
        }

        FillFile(ToJson(comptes), COMPTES_JSON_PATH);
    }
}