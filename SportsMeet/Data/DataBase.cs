using Dapper;
using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsMeet.Data
{
    internal class DataBase
    {
        public DataBase()
        {
        }

        public static List<Player> LoadPlayers()
        {
            var output = DBConnection.Instance.Connection.Query<Player>("select * from Players", new DynamicParameters());
            return output.ToList();
        }

        public static void SavePlayer(Player player)
        {
            DBConnection.Instance.Connection.Execute("insert into Players (number, firstName, lastName, age) values (@Number, @FirstName, @LastName, @Age)", player);
        }

        public static void RemovePlayer(Player player)
        {
            DBConnection.Instance.Connection.Execute("DELETE FROM Players WHERE (number) = (@Number)", player);
        }

        public static List<School> LoadSchools()
        {
            var output = DBConnection.Instance.Connection.Query<School>("select * from Schools", new DynamicParameters());
            return output.ToList();
        }

        public static List<District> LoadDistricts()
        {
            var output = DBConnection.Instance.Connection.Query<District>("select * from Districts", new DynamicParameters());
            return output.ToList();
        }

        public static List<String> LoadPlayerNumbers()
        {
            var output = DBConnection.Instance.Connection.Query<String>("select number from Players", new DynamicParameters());
            return output.ToList();
        }
    }
}