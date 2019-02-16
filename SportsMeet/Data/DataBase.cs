using Dapper;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.Sql;
using System.Data.SQLite;
using System.Text;
using SportsMeet.Models;


namespace SportsMeet.Data
{
    class DataBase
    {
        //private SqliteConnection dbConnection;

        public DataBase()
        {
            //dbConnection = new SqliteConnection("Data_Source=data/meet.db");
            if (!File.Exists("Data/meet.db"))
            {
             //   SqliteConnection.crea
            }
        }

        public static List<Player> LoadPlayers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Player>("select * from Players", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePlayer(Player player)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("insert into Players (number, firstName, lastName, age) values (@Number, @FirstName, @LastName, @Age)", player);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
