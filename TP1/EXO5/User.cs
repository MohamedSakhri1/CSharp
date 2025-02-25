using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5
{
    internal abstract class User
    {
        private int id;
        protected string nom;
        protected string prenom;
        protected string email;
        protected string password;

        protected Role role;

        protected User() { }

        protected User(string nom, string prenom, string email, string password, Role role)
        {
            id = getNextIndex();
            Nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value.ToUpper(); } }
        public string Prenom { get {return prenom; } set { prenom = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public Role Role { get { return role; } set { role = value; } }

        private int getNextIndex()
        {
            return JsonUtils.GetClients().Count() + 1;
        }


    }
}
