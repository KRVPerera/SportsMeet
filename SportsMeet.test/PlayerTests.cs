﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsMeet.Models;
using System;

namespace SportsMeet.test
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
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

        [TestMethod]
        public void TestCorrctAgeForPlayers()
        {
            Player newPlayer = new Player(123);

            newPlayer.Age = 14;

            Assert.IsTrue(14 == newPlayer.Age);
        }
    }
}