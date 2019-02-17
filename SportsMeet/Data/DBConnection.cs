using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace SportsMeet.Data
{
    public sealed class DBConnection
    {
        static IDbConnection connection = null;

        private static DBConnection instance = null;
        private static readonly object padlock = new object();

        private DBConnection()
        {
            connection = new SQLiteConnection(LoadConnectionString());
            connection.Open();
        }

        public static DBConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DBConnection();
                    }
                    return instance;
                }
            }
        }

        public IDbConnection Connection
        {
            get
            {
                return connection;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MeetTracker\\meet.db";

            if (!File.Exists(filePath))
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\meet.db";
            }

            var connectionString = "Data Source=" + filePath + "; Version=3";
            return connectionString;
        }

    }
}
