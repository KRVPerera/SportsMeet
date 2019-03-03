using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsMeet.Models;

namespace SportsMeet.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidAgeForPlayers()
        {
            Player newPlayer = new Player(123);

            try
            {
                newPlayer.Age = -2;

            }
            catch (ArgumentOutOfRangeException ex)
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
