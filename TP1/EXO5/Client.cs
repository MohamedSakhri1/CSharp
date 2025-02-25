using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EXO5
{
    internal class Client : User
    {
        private Compte compte;

        public Client() { }
        public Client(string nom, string prenom, string email = "exemple@email.com", string password = "123", Role role = Role.CLIENT) : base(nom, prenom, email, password, role)
        { 
            JsonUtils.StoreClient(this);
        }

        [JsonIgnore]
        public Compte Compte { get { return compte; } set { compte = value; } }

        public void CreateCompte(int numeroCompte, double soldeInitial = 0)
        {
            if (compte != null)
                throw new FieldAccessException("Le user a déjà un compte !");
            // compte non trouvé
            compte = new Compte(numeroCompte, soldeInitial, this.Id);
            JsonUtils.StoreCompte(this.compte);
        }




    }
}
