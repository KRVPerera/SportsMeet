using System;
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
        public DataBase()
        {
        }

        public static List<Player> LoadPlayers()
        {
            var output = DBConnection.Connection.Query<Player>("select * from Players", new DynamicParameters());
            return output.ToList();
        }

        public static void SavePlayer(Player player)
        {
            DBConnection.Connection.Execute("insert into Players (number, firstName, lastName, age) values (@Number, @FirstName, @LastName, @Age)", player);
        }

    }
}
