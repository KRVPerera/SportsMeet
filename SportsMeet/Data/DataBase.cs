using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;

namespace SportsMeet.Data
{
    class DataBase
    {
        private SqliteConnection dbConnection;

        public DataBase()
        {
            dbConnection = new SqliteConnection("Data_Source=data/meet.db");
            if (!File.Exists("data/meet.db"))
            {
                SqliteConnection.crea
            }
        }

    }
}
