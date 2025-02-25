using System;
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
        try
        {
            //if (File.Exists(filePath)) { }
            
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex) { throw new Exception("Erreur dans louverture de fichier JSON !"); }
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

    public static Client GetClientByMail(string mail)
    {
        var clients = GetClients();
        try
        {
            var myClient = clients.FirstOrDefault(client => client.Email == mail);
            myClient.Compte = GetUserCompte(myClient.Id);

            return myClient;
        }
        catch (Exception ex) { return clients.FirstOrDefault(client => client.Email == mail); }
    }

    public static Client GetClientById(int id)
    {
        var clients = GetClients();
        try
        {
            var myClient = clients.First(client => client.Id == id);
            myClient.Compte = GetUserCompte(myClient.Id);

            return myClient;
        }
        catch (InvalidOperationException ex) { throw new Exception("Pas du client avec id=" + id + " !"); }
        catch (Exception ex) { return clients.First(client => client.Id == id); }
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



    public static Compte GetCompteByNumero(int numero)
    {
        try
        {
            var comptes = GetComptes();
            return comptes.First(compte => compte.Numero == numero);
        }
        catch (Exception ex) {
            throw new Exception("Pas du compte avec numero=" + numero + " !");
        }
    }

    public static Compte GetUserCompte(int idClient)
    {
        try
        {
            var comptes = GetComptes();
            return comptes.First(compte => compte.ClientId == idClient);
        }
        catch (Exception ex) { throw new Exception("Pas du compte pour le User avec id=" + idClient + " !"); }
    }

    public static void StoreCompte(Compte compte)
    {
        List<Compte> comptes = GetComptes();
        comptes.Add(compte);

        FillFile(ToJson(comptes), COMPTES_JSON_PATH);
    }

    public static void UpdateCompte(Compte newCompte)
    {
        try
        {
            List<Compte> comptes = GetComptes();
            Compte oldCompte = GetCompteByNumero(newCompte.Numero);
            
            comptes.RemoveAll(compte => compte.Numero == newCompte.Numero);
            comptes.Add(newCompte);
            
            FillFile(ToJson(comptes), COMPTES_JSON_PATH);
        }
        catch (Exception ex) { throw ex; }
    }
}