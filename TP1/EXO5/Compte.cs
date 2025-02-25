using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5
{
    internal class Compte
    {
        private int numero;
        private double solde;
        private List<Transaction> transactions;
        private int clientId;

        public Compte() { }
        public Compte(int numero, double solde = 0, int clientId = 0)
        {
            this.numero = numero;
            this.solde = solde;
            this.transactions = new List<Transaction>();
            this.clientId = clientId;
        }

        public override string ToString() {

            Client client = JsonUtils.GetClientById(clientId);

            string stringValue = numero +  " - " + client.Nom + " " + client.Prenom;
            stringValue += " - " + solde + "dhs / " + transactions.Count + "operation(s) effectuee(s)";

            return stringValue;
        }

        public int Numero { get { return numero; } set { numero = value; } }
        public double Solde { get { return solde; } set { solde = value; } }
        public int ClientId { get { return clientId; } set { clientId = value; } }
        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }


        public void Crediter(double montant)
        {
            if (montant < 0)
                throw new Exception("Montant negative !");
            solde += montant;
            
            Transaction transaction = new Transaction(OperationBancaire.CRIDITER,solde, montant);

            transactions.Add(transaction);

            JsonUtils.UpdateCompte(this);
        }

        public void Debiter(double montant)
        {
            if (montant < 0)
                throw new Exception("Montant negative !");
            if (solde < montant)
                throw new Exception("Solde insufisant !");

            solde -= montant;

            Transaction transaction = new Transaction(OperationBancaire.DEBITER, solde, montant);
            transactions.Add(transaction);


            JsonUtils.UpdateCompte(this);
        }

        public void Verser(double montant, int numeroCompteReceptrice)
        {
            try
            {
                Compte compteReceptrice = JsonUtils.GetCompteByNumero(numeroCompteReceptrice);

                if (compteReceptrice == null)
                    throw new Exception("Compte introuvable !");

                this.Debiter(montant);
                compteReceptrice.Crediter(montant);

            } catch (Exception ex) {
                    throw ex;
            }

        }

    }
}
