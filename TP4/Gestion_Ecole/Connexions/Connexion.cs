using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Gestion_Ecole.Connexions
{
    internal class Connexion : IConnexion
    {
        NpgsqlConnection cnx;

        public void Connect(string db_name, string host = "localhost", string username = "postgres", string password = "mohamed")
        {
            string chaine_cnx = $"User Id={username};Password={password}; Host={host};Database={db_name}";
            cnx = new NpgsqlConnection(chaine_cnx);
            cnx.Open();
        }

        public int iud(string sql, Dictionary<string, object> parameters = null)
        {
            using (var cmd = new NpgsqlCommand(sql,cnx) )
            {
                if (parameters != null)
                    foreach (var param in parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = param.Key;
                        p.Value = param.Value;
                        cmd.Parameters.Add(p);
                    }
                int response = cmd.ExecuteNonQuery();

                return response;
            }
        }

        public IDataReader select(string sql, Dictionary<string, object> parameters = null)
        {
            using (var cmd = new NpgsqlCommand(sql, cnx))
            {
                if (parameters != null)
                    foreach (var param in parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = param.Key;
                        p.Value = param.Value;
                        cmd.Parameters.Add(p);
                    }

                var reader = cmd.ExecuteReader();

                return reader;
            }
        }

    }
}
