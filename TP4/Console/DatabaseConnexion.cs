using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Console
{
    internal class DatabaseConnexion
    {
        private NpgsqlConnection instance = null;

        private static string connectionString = "Host=localhost;Username=postgres;Password=mohamed;Database=CSharpTP4";

        private DatabaseConnexion()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                instance = conn;
            }
        }

        public static NpgsqlConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnexion();
            }

            return instance;
        }
    }
}
