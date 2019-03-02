using Dapper;
using Dapper.Contrib.Extensions;
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

        #region Players

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

        public static Player FindPlayerByNumber(Player player)
        {
            string query = "select * from Players where number=@Number;";
            var output = DBConnection.Instance.Connection.QueryFirstOrDefault<Player>(query, player);
            return output;
        }

        public static bool RemovePlayer(Player player)
        {
            return DBConnection.Instance.Connection.Delete(player);
        }

        public static List<String> LoadPlayerNumbers()
        {
            var output =
                DBConnection.Instance.Connection.Query<String>("select number from Players", new DynamicParameters());
            return output.ToList();
        }

        public static Player FindPlayerById(Player player)
        {
            string query = "select * from Players where id=@Id;";
            var output = DBConnection.Instance.Connection.QueryFirstOrDefault<Player>(query, player);
            return output;
        }

        #endregion Players

        #region Schools

        public static List<School> LoadSchools()
        {
            var output =
                DBConnection.Instance.Connection.Query<School>("select * from Schools", new DynamicParameters());
            return output.ToList();
        }

        public static List<String> LoadSchoolNames()
        {
            var output =
                DBConnection.Instance.Connection.Query<String>("select name from Schools", new DynamicParameters());
            return output.ToList();
        }

        public static long SaveSchool(School school)
        {
            return DBConnection.Instance.Connection.Insert(school);
        }

        public static bool EditSchool(School oldSchool)
        {
            return DBConnection.Instance.Connection.Update(oldSchool);
        }

        public static School GetSchool(String schoolName)
        {
            string query = "select * from Schools where Name = @Name";
            Event namedSchool = new Event(0, "", schoolName, 1, 17);

            IEnumerable<School> result = DBConnection.Instance.Connection.Query<School>(query, namedSchool);
            return result.FirstOrDefault();
        }

        public static bool RemoveSchool(School searchedSchool)
        {
            return DBConnection.Instance.Connection.Delete(searchedSchool);
        }

        #endregion Schools

        #region Events

        public static long SaveEvent(Event neweEvent)
        {
            return DBConnection.Instance.Connection.Insert(neweEvent);
        }

        public static Event GetEventByName(String eventName)
        {
            string query = "select * from Events where Name = @Name";
            Event namedEvent = new Event(0, "", eventName, 1, 17);

            IEnumerable<Event> result = DBConnection.Instance.Connection.Query<Event>(query, namedEvent);
            return result.FirstOrDefault();
        }

        public static bool EditEvent(Event oldEvent)
        {
            return DBConnection.Instance.Connection.Update(oldEvent);
        }

        public static IEnumerable<Event> LoadEvents()
        {
            return DBConnection.Instance.Connection.GetAll<Event>();
        }

        public static Event GetEventByNumber(string cbxText)
        {
            string query = "select * from Events where number = @Number";
            Event namedEvent = new Event(0, cbxText, "", 1, 17);

            IEnumerable<Event> result = DBConnection.Instance.Connection.Query<Event>(query, namedEvent);
            return result.FirstOrDefault();
        }

        public static Event GetEventById(long id)
        {
            string query = "select * from Events where id = @Id;";
            Event namedEvent = new Event(id, "", "", 1, 17);

            IEnumerable<Event> result = DBConnection.Instance.Connection.Query<Event>(query, namedEvent);
            return result.FirstOrDefault();
        }

        public static Event GetEventByAgeLimit(int age)
        {
            string query = "select * from Events where agelimit = @AgeLimit";
            Event namedEvent = new Event(0, "", "", 1, age);

            IEnumerable<Event> result = DBConnection.Instance.Connection.Query<Event>(query, namedEvent);
            return result.FirstOrDefault();
        }

        public static List<String> LoadEventNumbers()
        {
            var output =
                DBConnection.Instance.Connection.Query<String>("select number from Events", new DynamicParameters());
            return output.ToList();
        }

        public static bool RemoveEvent(Event searchedNumberedEvent)
        {
            return DBConnection.Instance.Connection.Delete(searchedNumberedEvent);
        }

        #endregion Events

        #region Districts

        public static List<District> LoadDistricts()
        {
            var output =
                DBConnection.Instance.Connection.Query<District>("select * from Districts", new DynamicParameters());
            return output.ToList();
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

        #endregion Districts

        #region PlayerEvents

        public static long SavePlayerEvent(PlayerEvent playerEvent)
        {
            return DBConnection.Instance.Connection.Insert(playerEvent);
        }

        public static PlayerEvent GetPlayerEvent(PlayerEvent playerEvent)
        {
            string query = "select * from PlayerEvents where eventId = @EventId and playerId = @PlayerId;";
            IEnumerable<PlayerEvent> result = DBConnection.Instance.Connection.Query<PlayerEvent>(query, playerEvent);
            return result.FirstOrDefault();
        }

        public static List<PlayerEvent> GetPlayerEventsByPlayer(PlayerEvent searchedPlayerEvent)
        {
            string query = "select * from PlayerEvents where playerId = @PlayerId;";
            IEnumerable<PlayerEvent> result = DBConnection.Instance.Connection.Query<PlayerEvent>(query, searchedPlayerEvent);
            return result.ToList();
        }

        public static List<Event> GetEventsForPlayerEvents(List<PlayerEvent> playerEventList)
        {
            List<Event> eventList = new List<Event>();
            List<long> eventIdList = Util.GetEventIdListFromPlayerEventList(playerEventList);
            foreach (var eventId in eventIdList)
            {
                Event searchedEvent = GetEventById(eventId);
                if (searchedEvent != null)
                {
                    eventList.Add(searchedEvent);
                }
            }
            return eventList;
        }

        #endregion PlayerEvents
    }
}