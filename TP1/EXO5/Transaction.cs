using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5
{
    internal class Transaction
    {
        private double montant;
        private double solde;
        private OperationBancaire typeOperation;
        private string date;

        public Transaction() { }
        public Transaction(OperationBancaire typeOperation,double solde ,double montant = 0)
        {
            this.montant = montant;
            this.solde = solde;
            this.typeOperation = typeOperation;
            this.date = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        public double Montant { get { return montant; } set { montant = value; } }
        public double Solde { get { return solde; } set { solde = value; } }
        public OperationBancaire TypeOperation { get { return typeOperation; } set { typeOperation = value; } }
        public string Date { get { return date; } set { date = value; } }

        public override string ToString() {

            var type = "";
            if (typeOperation.Equals(OperationBancaire.CRIDITER))
                type = "cridite";
            else if (typeOperation.Equals(OperationBancaire.DEBITER))
                type = "debite";

            string stringValue = "*** Operation " + type + ": " + date.ToString() + " ***\n";
            stringValue += "\tMantant: " + montant.ToString() + " dhs\n";
            stringValue += "\tSolde: " + solde.ToString() + " dhs\n";

            return stringValue;
        }
    }
}
