using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;


namespace BiblioDAO
{
    public class DAO : Connexion, IDAO<object>
    {
        private static string tableName;
        private static List<PropertyInfo> properties = new List<PropertyInfo>();

        public int id = 0;
        public int Id { get { return id; } set { id = value; } }

        public DAO()
        {
            tableName = this.GetType().Name;
            properties = this.GetType().GetProperties()  // .Select(p => p.Name)
                                .ToList();
            Connect();
            
        }
        public DAO(int id) : this()
        {
            this.id = id;
        }

        public int insert()
        {
            var filteredProperties = properties.Where(p => !p.Name.ToLower().Equals("id")).Select(p => p.Name).ToList();

            string columns = string.Join(",", filteredProperties);
            string values = string.Join(",", filteredProperties.Select(p => "@" + p));


            string sql = $"insert into {tableName}({columns}) values ({values})";

            // Construire dynamiquement le dictionnaire des paramètres
            Dictionary<string, object> param = new Dictionary<string, object>();
            foreach (var prop in filteredProperties)
            {
                object value = this.GetType().GetProperty(prop).GetValue(this) ?? DBNull.Value;
                param.Add("@" + prop, value);
            }

            return iud(sql, param);
        }

        public int update()
        {
            var filteredProperties = properties.Where(p => !p.Name.ToLower().Equals("id")).Select(p => p.Name).ToList();
            string setters = string.Join(",", filteredProperties.Select(p => p + "=@" + p));

            string id = this.GetType().GetProperty("Id").GetValue(this).ToString();
            string sql = $"update {tableName} set {setters} where id={id}";

            // Construire dynamiquement le dictionnaire des paramètres
            Dictionary<string, object> param = new Dictionary<string, object>();
            foreach (var prop in filteredProperties)
            {
                object value = this.GetType().GetProperty(prop).GetValue(this) ?? DBNull.Value;
                param.Add("@" + prop, value);
            }

            return iud(sql, param);
        }

        public int delete()
        {
            string sql = $"delete from {tableName} where id=@id";

            Dictionary<string, object> param = new Dictionary<string, object>() { { "@id", id } };

            return iud(sql, param);
        }

        public object findById()
        {
            IDataReader reader = null;

            string sql = $"select * from {tableName} where id={id};";


            reader = getDataReader( select(sql) );

            object instance = Activator.CreateInstance(this.GetType()); // Création d'une instance générique
            if (reader.Read())
            {
                foreach (var prop in this.GetType().GetProperties())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name.ToLower()))) // Vérifie si la colonne est non NULL
                    {
                        object value = reader.GetValue(reader.GetOrdinal(prop.Name));
                        prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                    }
                }
            }

            reader.Close();
            return instance;
        }

        public List<object> findAll()
        {
            List<object> list = new List<object>();
            IDataReader reader = null;

            string sql = $"select * from {tableName}";

            reader = getDataReader(select(sql));

            while (reader.Read())
            {
                object instance = Activator.CreateInstance(this.GetType()); // Création d'une instance générique

                foreach (var prop in this.GetType().GetProperties())
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

        public List<object> find()
        {
            List<object> list = new List<object>();
            IDataReader reader = null;

            string sql = $"select * from {tableName} where ";

            Dictionary<string, object> dico = new Dictionary<string, object>();

            dico = this.ObjectToDictionary();

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

            reader = getDataReader(select(sql, dico));

            while (reader.Read())
            {
                object instance = Activator.CreateInstance(this.GetType()); // Création d'une instance générique

                foreach (var prop in this.GetType().GetProperties())
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




        public Dictionary<string, object> ObjectToDictionary()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            foreach (PropertyInfo p in this.GetType().GetProperties())
            {
                if (p.GetValue(this) != null && !p.GetValue(this).ToString().Trim().Equals(string.Empty))
                {
                    if (p.Name == "Id")
                        dico["id"] = p.GetValue(this);
                    else
                        dico[p.Name.ToLower()] = p.GetValue(this);
                }
            }
            return dico;
        }

        public object DictionaryToObject(Dictionary<string, object> dico)
        {
            object instance = Activator.CreateInstance(this.GetType()); // Création d'une instance générique

            foreach (var prop in this.GetType().GetProperties())
            {
                object value = dico[prop.Name];

                if (value != null)
                    prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                else
                    prop.SetValue(instance, null);
            }

            return instance;
        }
    }
}
