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
        private const string ID = "Default";

        public List<Flight> LoadFlights(string query)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = dbConnection.Query<Flight>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }
}
