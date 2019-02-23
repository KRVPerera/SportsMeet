using Dapper;
using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;

namespace SportsMeet.Data
{
    internal class DataBase
    {
        public DataBase()
        {
        }

        public static IEnumerable<Player> LoadPlayers()
        {
            //var output = DBConnection.Instance.Connection.Query<Player>("select * from Players", new DynamicParameters());
            //return output.ToList();
            return DBConnection.Instance.Connection.GetAll<Player>();
        }

        public static long SavePlayer(Player player)
        {
            return DBConnection.Instance.Connection.Insert(player);
        }

        public static bool EditPlayer(Player player)
        {
           return DBConnection.Instance.Connection.Update(player);
        }

        public static Player FindPlayer(Player player)
        {
            string query = "select * from Players where number=@Number;";
            var output = DBConnection.Instance.Connection.QueryFirstOrDefault<Player>(query, player);
            return output;
        }

        public static bool RemovePlayer(Player player)
        {
            return DBConnection.Instance.Connection.Delete(player);
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

        public static long SaveEvent(Event neweEvent)
        {
            return DBConnection.Instance.Connection.Insert(neweEvent);
        }

        public static District GetDistrict(Int64 districtId)
        {
            return DBConnection.Instance.Connection.Get<District>(districtId);
        }

        public static District GetDistrictByName(String districtName)
        {
            string query = "select * from Districts where Name = @Name";
            District nameDistrict = new District();
            nameDistrict.Name = districtName;
            
            IEnumerable<District> result = DBConnection.Instance.Connection.Query<District>(query, nameDistrict);
            return result.FirstOrDefault();
        }
    }
}