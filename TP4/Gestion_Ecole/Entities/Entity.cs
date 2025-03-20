using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.Entities
{
    internal class Entity
    {
        public Dictionary<string, object> ToDictionary()
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
    }
}
