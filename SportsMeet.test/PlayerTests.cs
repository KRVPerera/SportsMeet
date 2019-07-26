using SportsMeet.Models;
using SportsMeet.Reports;
using System;
using NUnit.Framework;
using System.IO;

namespace SportsMeet.test
{
    public class PlayerTests
    {
        [Test]
        public void TestInvalidAgeForPlayers()
        {
            Player newPlayer = new Player(123);

            try
            {
                newPlayer.Age = -2;
            }
            catch (ArgumentOutOfRangeException)
            {
                // ok
            }

            Assert.IsTrue(0 == newPlayer.Age);
        }

        [Test]
        public void TestCorrctAgeForPlayers()
        {
            Player newPlayer = new Player(123);

            newPlayer.Age = 14;

            Assert.IsTrue(14 == newPlayer.Age);
        }
    }


    public class ReportTest
    {
        
        public void SampleReport()
        {

            var folderPath = Path.GetTempPath() + "\\MeetTest";

            Directory.CreateDirectory(folderPath);

            ReportManager reportManager = new ReportManager(folderPath);
            reportManager.Report();

            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath);
            }
        }
    }
}