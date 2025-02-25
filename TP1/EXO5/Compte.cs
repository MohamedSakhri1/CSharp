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


        public void Criditer(double montant)
        {
            if (montant < 0)
                return;
            solde += montant;
            
            Transaction transaction = new Transaction(OperationBancaire.CRIDITER,solde, montant);

            transactions.Add(transaction);

            JsonUtils.UpdateCompte(numero,this);
        }

        public void Debiter(double montant)
        {
            if (montant < 0)
                return;
            if (solde < montant)
                return;

            solde -= montant;

            Transaction transaction = new Transaction(OperationBancaire.DEBITER, solde, montant);
            transactions.Add(transaction);


            JsonUtils.UpdateCompte(numero, this);
        }

    }
}
