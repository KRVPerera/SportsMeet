using System;
using System.Collections.Generic;
using System.Configuration;
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
    
                var connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
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
                Console.WriteLine("Success!");
                Console.ResetColor();
                return 0;
            
        }
    }
}
