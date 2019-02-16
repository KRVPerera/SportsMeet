using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DbUp;

namespace MeetDataBaseGen
{
    class Program
    {
        static int Main(string[] args)
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MeetTracker";
            try
            {
                Directory.CreateDirectory(folderPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("Could not create path : {0}", e.ToString());
                folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            }

            var connectionString = "Data Source=" + folderPath + "\\meet.db; Version=3";
            //EnsureDatabase.For.SQLiteDatabase(connectionString);

            var upgrader =
                    DeployChanges.To
                        .SQLiteDatabase(connectionString)
                        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                        .LogToConsole()
                        .Build();

                var result = upgrader.PerformUpgrade();

                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
#if DEBUG
                    Console.ReadLine();
#endif
                    return -1;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(connectionString);
                Console.WriteLine("Success!");
                Console.ResetColor();
                return 0;
            
        }
    }
}
