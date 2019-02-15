using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Text;

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

    }
}
