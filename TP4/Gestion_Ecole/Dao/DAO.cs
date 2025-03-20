using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Ecole.Connexions;
using Gestion_Ecole.Entities;
using Npgsql;

namespace Gestion_Ecole.Dao
{
    internal class DAO<T> : Connexion, IDAO<T> where T : Entity, new()
    {
        private static string tableName = typeof(T).Name;
        private static List<string> properties = new List<string>();

        public List<string> Properties { get { return properties; } }


        public DAO(string databaseName = "CSharpTP4")
        {
            properties = typeof(T).GetProperties()
                          .Select(p => p.Name)
                          .ToList();

            Connect(databaseName);
        }
        public int delete(int id)
        {
            string sql = $"delete from {tableName} where id=@id";

            Dictionary<string, object> param = new Dictionary<string, object>() { { "@id", id } };

            return iud(sql, param);
        }

        public List<T> find(T o)
        {
            List<T> list = new List<T>();
            NpgsqlDataReader reader = null;

            string sql = $"select * from {tableName} where ";

            Dictionary<string, object> dico = new Dictionary<string, object>();

            dico = o.ToDictionary();

            foreach (var p in dico)
            {
                if (p.Key.ToLower().Equals("id"))
                    continue;

                if (p.Value is string)
                    sql += $"{p.Key} like @{p.Key} || '%' and ";
                else if (p.Value is int && int.Parse(p.Value.ToString()) > 0)
                    sql += $"{p.Key}=@{p.Key} and ";
            }
            sql += "1=1";

            reader = (NpgsqlDataReader)select(sql, dico);

            while (reader.Read())
            {
                T instance = new T(); // Création d'une instance générique

                foreach (var prop in typeof(T).GetProperties())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name))) // Vérifie si la colonne est non NULL
                    {
                        object value = reader.GetValue(reader.GetOrdinal(prop.Name));
                        prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                    }
                }

                list.Add(instance);
            }

            reader.Close();

            return list;
        }

        public List<T> findAll()
        {
            List<T> list = new List<T>();
            NpgsqlDataReader reader = null;

            string sql = $"select * from {tableName}";

            reader = (NpgsqlDataReader)select(sql);

            while (reader.Read())
            {
                T instance = Activator.CreateInstance<T>(); // Création d'une instance générique

                foreach (var prop in typeof(T).GetProperties())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name))) // Vérifie si la colonne est non NULL
                    {
                        object value = reader.GetValue(reader.GetOrdinal(prop.Name));
                        prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                    }
                }

                list.Add(instance);
            }
            
            reader.Close();
            return list;
        }

        public T findById(int id)
        {
            NpgsqlDataReader reader = null;

            string sql = $"select * from {tableName} where id={id};";


            reader = (NpgsqlDataReader)select(sql);

            T instance = Activator.CreateInstance<T>(); // Création d'une instance générique
            if (reader.Read())
            {
                foreach (var prop in typeof(T).GetProperties())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name.ToLower()))) // Vérifie si la colonne est non NULL
                    {
                        object value = reader.GetValue(reader.GetOrdinal(prop.Name));
                        prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                    }
                }
                reader.Close();
            }

            return instance;
        }

        public int insert(T o)
        {
            var filteredProperties = properties.Where(p => !p.ToLower().Equals("id")).ToList();

            string columns = string.Join(",", filteredProperties);
            string values = string.Join(",", filteredProperties.Select(p => "@" + p));


            string sql = $"insert into {tableName}({columns}) values ({values})";

            // Construire dynamiquement le dictionnaire des paramètres
            Dictionary<string, object> param = new Dictionary<string, object>();
            foreach (var prop in filteredProperties)
            {
                object value = typeof(T).GetProperty(prop).GetValue(o) ?? DBNull.Value;
                param.Add("@" + prop, value);
            }

            return iud(sql, param);
        }

        public int update(T o)
        {
            var filteredProperties = properties.Where(p => !p.ToLower().Equals("id")).ToList();
            string setters = string.Join(",", filteredProperties.Select(p => p + "=@" + p));

            string id = typeof(T).GetProperty("Id").GetValue(o).ToString();
            string sql = $"update {tableName} set {setters} where id={id}";

            // Construire dynamiquement le dictionnaire des paramètres
            Dictionary<string, object> param = new Dictionary<string, object>();
            foreach (var prop in filteredProperties)
            {
                object value = typeof(T).GetProperty(prop).GetValue(o) ?? DBNull.Value;
                param.Add("@" + prop, value);
            }

            return iud(sql, param);
        }
    }
}
