using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace LibraryWebApp.AccessDB
{
    public class SQLTool
    {
        private OleDbConnection conn = null;

        public SQLTool()
        {
            string conString = $"Provider=Microsoft.JET.OLEDB.4.0; data source={Path.Combine(Directory.GetCurrentDirectory(), "LibDB.mdb")}";
            conn = new OleDbConnection(conString);
        }
    }
}