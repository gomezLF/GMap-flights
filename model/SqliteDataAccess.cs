using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class SqliteDataAccess
    {
        private SQLiteConnection sQLiteConnection;

        public SqliteDataAccess()
        {
            sQLiteConnection = new SQLiteConnection("Data Source=./flights_database.db;Version=3;");
        }

        public void LoadData()
        {

        }

        private void OpenConnection()
        {
            sQLiteConnection.Open();
        }

        private void CloseConnection()
        {
            sQLiteConnection.Close();
        }
    }
}
