using DbUp;
using DbUp.Engine;
using System;
using System.IO;
using System.Reflection;

namespace MeetDataBaseGen
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            bool debug = (args.Length != 0);

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

            UpgradeEngine upgrader = null;

            try
            {
                upgrader =
                    DeployChanges.To
                        .SQLiteDatabase(connectionString)
                        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                        .LogToConsole()
                        .Build();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }

            if (!upgrader.IsUpgradeRequired())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.ResetColor();
                if (debug)
                {
                    Console.ReadKey();
                }
                return 0;
            }

            DatabaseUpgradeResult result = null;

            try
            {
                result = upgrader.PerformUpgrade();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
                    if (debug)
                    {
                        Console.ReadKey();
                    }
                    return -1;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(connectionString);
            Console.WriteLine("Success!");
            Console.ResetColor();
            if (debug)
            {
                Console.ReadKey();
            }
            return 0;
        }
    }
}