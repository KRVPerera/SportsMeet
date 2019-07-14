using Dapper;
using Dapper.Contrib.Extensions;
using SportsMeet.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Caching;

namespace SportsMeet.Data
{
    internal class DataBase
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


        #region public constructors

        public DataBase()
        {
        }

        #endregion


        #region Players

        public static IEnumerable<Player> LoadPlayers()
        {
            return DBConnection.Instance.Connection.GetAll<Player>();
        }

        public static List<Player> LoadPlayers(Player sPlayer)
        {
            Console.WriteLine(sPlayer.FullName());
            string query = @"
            SELECT *
            FROM players
            where   
                    firstName LIKE @FirstName AND
                    lastName LIKE @LastName AND
                    age LIKE @Age AND
                    number LIKE @Number
                ;
            ";

            var p = new
            {
                FirstName = "%" + sPlayer.FirstName + "%",
                LastName = "%" + sPlayer.LastName + "%",
                Age = sPlayer.Age.ToString(),
                Id = sPlayer.Id.ToString() + "%",
                Number = sPlayer.Number.ToString() + "%"
            };

            Console.WriteLine(sPlayer.FullName());

            var players = DBConnection.Instance.Connection.Query<Player>(query, p)
                            .Distinct()
                            .ToList();

            Console.WriteLine(players.Count);
            return players;

        }

        /*
        public static List<Player> LoadPlayers(PlayerEventData playerEventData)
        {
//            string query = "select * from PlayerEvents where eventId = @EventId and playerId = @PlayerId;";
            string query = @"
            SELECT pls.*,pes.*,evs.*
            FROM (
                (players pls INNER JOIN playerevents  pes ON pls.id = pes.playerId)
                INNER JOIN events evs ON evs.id = pes.eventId
                )

                where   pls.firstName LIKE @FirstName AND
                        pls.lastName LIKE @LastName
                ;
            ";

            Player sPlayer = playerEventData.PlayerData;
            Event sEvent = playerEventData.EventData;

            if (sPlayer.FirstName == "")
            {
                sPlayer.FirstName = "%";
            }

            if (sPlayer.LastName == "")
            {
                sPlayer.LastName = "%";
            }

            var p = new
            {
                FirstName = sPlayer.FirstName,
                LastName = sPlayer.LastName
            };

            var players = DBConnection.Instance.Connection.Query<Player, PlayerEventData, Event, Player>(
                    query,
                    (pPlayer, pevent, eEvent) =>
                    {
                        pevent.PlayerData = pPlayer;
                        pevent.EventData = eEvent;
                        return pPlayer;
                    }, p, commandType: System.Data.CommandType.Text,
                    splitOn: "id,eventId,id")
                .Distinct()
                .ToList();

            Console.WriteLine(players.Count);
            foreach (var dt1 in players)
            {
                string ss = dt1.ToString();
                Console.WriteLine(ss);
                
            }

            return players;

        }
        */

        public static long SavePlayer(Player player)
        {
//            DapperPlusManager.Entity<Supplier>().Table("Suppliers").Identity(x => x.SupplierID);
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

        public static Player FindPlayer(Player player, Event eEvent)
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
            School namedSchool = new School(0, schoolName);

            IEnumerable<School> result = DBConnection.Instance.Connection.Query<School>(query, namedSchool);
            return result.FirstOrDefault();
        }

        public static bool RemoveSchool(School searchedSchool)
        {
            return DBConnection.Instance.Connection.Delete(searchedSchool);
        }

        internal static School GetSchool(long schoolId)
        {
            string query = "select * from Schools where id = @Id";
            School idedSchool = new School(schoolId, "");

            IEnumerable<School> result = DBConnection.Instance.Connection.Query<School>(query, idedSchool);
            return result.FirstOrDefault();
        }

        #endregion Schools


        #region Events

        internal static List<Event> GetEventsForEventIds(List<long> eventIds)
        {
            List<Event> eventList = new List<Event>();
            foreach (var eventId in eventIds)
            {
                Event searchedEvent = GetEventById(eventId);
                if (searchedEvent != null)
                {
                    eventList.Add(searchedEvent);
                }
            }
            return eventList;
        }

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
            string cache_key = "DISTRICTS";

            ObjectCache cache = MemoryCache.Default;

            IEnumerable<District> districts = cache[cache_key] as IEnumerable<District>;

            if (districts == null)
            {
                districts =
                    DBConnection.Instance.Connection.Query<District>("select * from Districts", new DynamicParameters());

                cache.Set(cache_key, districts, DateTimeOffset.MaxValue);
                logger.Debug("Cache set district");
            }
            else 
            {
                logger.Debug("Cache hit district");
            }

            return districts.ToList();
        }

        public static District GetDistrict(Int64 districtId)
        {
//            return DBConnection.Instance.Connection.Get<District>(districtId);

            string cache_key = "DISTRICTS_ID_MAP";

            ObjectCache cache = MemoryCache.Default;
            District resDistrict = null;

            Dictionary<Int64, District> districtsMDictionary = cache[cache_key] as Dictionary<Int64, District>;

            if (districtsMDictionary == null)
            {
                List<District> districts = LoadDistricts();
                districtsMDictionary = new Dictionary<Int64, District>();

                foreach (var district in districts)
                {
                    Int64 disId = district.Id;

                    if (disId == districtId)
                    {
                        resDistrict = district;
                    }

                    districtsMDictionary.Add(disId, district);
                }

                cache.Set(cache_key, districtsMDictionary, DateTimeOffset.MaxValue);
                logger.Debug("Cached set district by id");
            }
            else
            {
                if (!districtsMDictionary.TryGetValue(districtId, out resDistrict))
                {
                    /*string query = "select * from Districts where Name = @Name";
                    District nameDistrict = new District();
                    nameDistrict.Name = districtName;
                    IEnumerable<District> result = DBConnection.Instance.Connection.Query<District>(query, nameDistrict);
                    resDistrict = result.FirstOrDefault();*/
                    logger.Debug("District by id not found in cache");
                }
                else
                {
                    logger.Debug("Cached used district by id");
                }

            }

            return resDistrict;
        }

        public static District GetDistrictByName(String districtName)
        {
            string cache_key = "DISTRICTS_NAME_MAP";

            ObjectCache cache = MemoryCache.Default;
            District resDistrict = null;

            Dictionary<String, District> districtsMDictionary = cache[cache_key] as Dictionary<String, District>;

            if (districtsMDictionary == null)
            {
                List<District> districts = LoadDistricts();
                districtsMDictionary = new Dictionary<string, District>();

                foreach (var district in districts)
                {
                    String disName = district.Name;

                    if (disName == districtName)
                    {
                        resDistrict = district;
                    }

                    districtsMDictionary.Add(district.Name, district);
                }

                cache.Set(cache_key, districtsMDictionary, DateTimeOffset.MaxValue);
                logger.Debug("Cached set district by name");
            }
            else
            {
                if (!districtsMDictionary.TryGetValue(districtName, out resDistrict))
                {
                    /*string query = "select * from Districts where Name = @Name";
                    District nameDistrict = new District();
                    nameDistrict.Name = districtName;
                    IEnumerable<District> result = DBConnection.Instance.Connection.Query<District>(query, nameDistrict);
                    resDistrict = result.FirstOrDefault();*/
                    logger.Debug("District by name not found in cache");
                }
                else
                {
                    logger.Debug("Cached used district by name");
                }
                
            }

            return resDistrict;
        }

        #endregion Districts


        #region EducationZones

        public static List<EducationZone> LoadEducationZones()
        {
            string cache_key = "EDUCATION_ZONES";

            ObjectCache cache = MemoryCache.Default;

            IEnumerable<EducationZone> educationZones = cache[cache_key] as IEnumerable<EducationZone>;

            if (educationZones == null)
            {
                educationZones =
                    DBConnection.Instance.Connection.Query<EducationZone>("select * from EducationZones", new DynamicParameters());

                cache.Set(cache_key, educationZones, DateTimeOffset.MaxValue);
                logger.Debug("Cache set district");
            }
            else
            {
                logger.Debug("Cache hit district");
            }

            return educationZones.ToList();
        }

        public static EducationZone GetEducationZone(Int64 educationId)
        {
            string cache_key = "EDUCATION_ZONES_ID_MAP";

            ObjectCache cache = MemoryCache.Default;
            EducationZone resEducation = null;

            Dictionary<Int64, EducationZone> educationZonesDictionary = cache[cache_key] as Dictionary<Int64, EducationZone>;

            if (educationZonesDictionary == null)
            {
                List<EducationZone> educationZoneList = LoadEducationZones();
                educationZonesDictionary = new Dictionary<Int64, EducationZone>();

                foreach (var zone in educationZoneList)
                {
                    Int64 zoneId = zone.Id;

                    if (zoneId == educationId)
                    {
                        resEducation = zone;
                    }

                    educationZonesDictionary.Add(zoneId, zone);
                }

                cache.Set(cache_key, educationZonesDictionary, DateTimeOffset.MaxValue);
                logger.Debug("Cached set EducationZone by id");
            }
            else
            {
                if (!educationZonesDictionary.TryGetValue(educationId, out resEducation))
                {
                    logger.Debug("EducationZone by id not found in cache");
                }
                else
                {
                    logger.Debug("Cached used EducationZone by id");
                }

            }

            return resEducation;
        }

        public static EducationZone GetEducationZone(String educationZoneName)
        {
            string cache_key = "EDUCATION_ZONES_NAME_MAP";

            ObjectCache cache = MemoryCache.Default;
            EducationZone resEducation = null;

            Dictionary<String, EducationZone> educationZonesDictionary = cache[cache_key] as Dictionary<String, EducationZone>;

            if (educationZonesDictionary == null)
            {
                List<EducationZone> educationZoneList = LoadEducationZones();
                educationZonesDictionary = new Dictionary<String, EducationZone>();

                foreach (var zone in educationZoneList)
                {
                    String zoneName = zone.Name;

                    if (zoneName == educationZoneName)
                    {
                        resEducation = zone;
                    }

                    educationZonesDictionary.Add(zoneName, zone);
                }

                cache.Set(cache_key, educationZonesDictionary, DateTimeOffset.MaxValue);
                logger.Debug("Cached set EducationZone by name");
            }
            else
            {
                if (!educationZonesDictionary.TryGetValue(educationZoneName, out resEducation))
                {
                    logger.Debug("EducationZone by name not found in cache");
                }
                else
                {
                    logger.Debug("Cached used EducationZone by name");
                }

            }

            return resEducation;
        }

        #endregion


        #region PlayerEvents

        public static long SavePlayerEvent(PlayerEvent playerEvent)
        {
            return DBConnection.Instance.Connection.Insert(playerEvent);
        }

        public static bool Delete(PlayerEvent playerEvent)
        {
            string query = "delete from PlayerEvents where eventId = @EventId and playerId = @PlayerId;";
            DBConnection.Instance.Connection.Query<int>(query, playerEvent);
            return true;
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

        public static List<PlayerEvent> GetPlayerEventsByEvent(PlayerEvent searchedPlayerEvent)
        {
            string query = "select * from PlayerEvents where eventId = @EventId;";
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

        public static List<Player> GetPlayersForPlayerEvents(List<PlayerEvent> playerEventList)
        {
            List<Player> playerList = new List<Player>();
            List<long> playerIdList = Util.GetPlayerIdListFromPlayerEventList(playerEventList);
            foreach (var playerId in playerIdList)
            {
                Player searchMe = new Player(playerId);
                Player searchedPlayer = FindPlayerById(searchMe);
                if (searchedPlayer != null)
                {
                    playerList.Add(searchedPlayer);
                }
            }
            return playerList;
        }

        public static List<long> GetPlayerEventsNotByPlayer(PlayerEvent searchPlayerEvents)
        {
            string query = "select id from Events where id not IN (select eventId from PlayerEvents where playerId = @PlayerId);";
            IEnumerable<long> result = DBConnection.Instance.Connection.Query<long>(query, searchPlayerEvents);
            return result.ToList();
        }

        #endregion PlayerEvents
    }
}