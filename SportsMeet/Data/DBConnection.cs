using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SportsMeet.Data
{
    public sealed class DBConnection
    {
        private static IDbConnection connection = null;

        private static DBConnection instance = null;
        private static readonly object padlock = new object();

        private DBConnection()
        {
            connection = new SQLiteConnection(LoadConnectionString());
            connection.Open();
            //            SanitizeDb();
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

        private void SanitizeDb()
        {
            if (connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='Players';") <= 0)
            {
                MessageBox.Show("Players table missing - Please reinstall.", "Table Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine(connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='Players';"));
                Environment.Exit(-1);
            }
            else
            if (connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='Events';") <= 0)
            {
                MessageBox.Show("Events table missing - Please reinstall.", "Table Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else

            if (connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='Districts';") <= 0)
            {
                MessageBox.Show("Districts table missing - Please reinstall.", "Table Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else

            if (connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='Schools';") <= 0)
            {
                MessageBox.Show("Schools table missing - Please reinstall.", "Table Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else

            if (connection.Execute("SELECT 1 FROM sqlite_master WHERE type='table' AND name='PlayerEvents';") <= 0)
            {
                MessageBox.Show("PlayerEvents table missing - Please reinstall.", "Table Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        public IDbConnection Connection
        {
            get
            {
                return connection;
            }
        }

        private static string LoadConnectionString()
        {
            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MeetTracker\\meet.db";

            if (!File.Exists(filePath))
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\meet.db";
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Database 'meet.db' missing - Please reinstall.", "Database Missing !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            var connectionString = "Data Source=" + filePath + "; Version=3";
            return connectionString;
        }
    }
}