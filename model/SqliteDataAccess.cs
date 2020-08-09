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
        

        public SqliteDataAccess()
        {
            
        }

        public DataTable LoadData(String query)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=./flights_database.db;Version=3;"))
            {
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection))
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    connection.Close();
                }
            }

            return dataTable;
        }
    }
}
