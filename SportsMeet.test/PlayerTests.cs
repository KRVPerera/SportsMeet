﻿using SportsMeet.Models;
using SportsMeet.Reports;
using System;
using NUnit.Framework;

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
        [Test]
        public void SampleReport()
        {

            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\MeetTest";
            ReportManager reportManager = new ReportManager
            {
                ReportPath = folderPath
            };

            reportManager.Report(folderPath);
        }
    }
}