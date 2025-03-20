using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Gestion_Ecole.Entities;
using Gestion_Ecole.Connexions;
using System.Data.SqlClient;
using Npgsql;

namespace Gestion_Ecole.Dao
{
    internal class EleveDAO : DAO<Eleve>
    {
        public EleveDAO() : base() { }


        public List<Eleve> Search(Eleve o)
        {
            List<Eleve> list = new List<Eleve>();
            NpgsqlDataReader reader = null;

            string sql = "select * from eleve where ";

            Dictionary<string, object> dico = new Dictionary<string, object>();

            dico = o.ToDictionary();

            foreach (var p in dico) {
                if (p.Value is string)
                    sql += p.Key + "like @" + p.Key + " and ";
                else
                    sql += p.Key + "=@" + p.Key + " and ";
            }
            sql += "1=1";

            reader = (NpgsqlDataReader)select(sql, dico);

            while (reader.Read())
                list.Add(
                    new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetInt32(5))
                    );
            return list;
        }


    }
}
