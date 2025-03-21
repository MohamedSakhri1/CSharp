﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDAO
{
    internal interface IConnexion : IDisposable
    {
        void Connect(); // string db_name, string host, string username, string password
        int iud(string sql, Dictionary<string, object> parameters);
        IDataReader select(string sql, Dictionary<string, object> parameters);
    }
}
