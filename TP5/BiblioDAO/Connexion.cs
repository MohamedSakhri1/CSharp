using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BiblioDAO
{
    public class Connexion : EnvManager, IConnexion
    {
        private IDbConnection cnx;
        private IDbCommand cmd;

        public Connexion() : base() { }

        public void Connect()
        {
            cnx = InitiliseDbConnection(); // depand du driver !

            cmd = cnx.CreateCommand();
            cnx.Open();
        }

        public void Dispose()
        {
            if (cmd != null)
                cmd.Dispose();
            if (cnx != null && cnx.State == ConnectionState.Open)
                cnx.Close();
        }

        public int iud(string sql, Dictionary<string, object> parameters = null)
        {
            cmd.CommandText = sql;
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

        public IDataReader select(string sql, Dictionary<string, object> parameters = null)
        {
            cmd.CommandText = sql;
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
