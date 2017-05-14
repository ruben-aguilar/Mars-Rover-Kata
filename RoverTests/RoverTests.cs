using System;
using Mars_Rover_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoverTests
{




    [TestClass]
    public class RoverTests
    {
        private Rover m_rover;

        [TestInitialize]
        public void SetUp()
        {
            m_rover = new Rover(0, 0, 'N');
        }

        [TestCleanup]
        public void TearDown()
        {
            m_rover = null;
        }

        [TestMethod]
        public void WhenCreateAMarsRoverWithCoordinatesAndDirection_ThenTheRoverHasTheseCoordinatesAndDirection()
        {
            int X = 1;
            int Y = 1;
            char direction = 'N';

            Rover rover = new Rover(X, Y, direction);

            Assert.AreEqual(X, rover.X);
            Assert.AreEqual(Y, rover.Y);
            Assert.AreEqual(direction, rover.Direction);
        }

        [TestMethod]
        public void GivenARoverInX0Y0AndInNorthDirection_WhenMoveForward_ItGoesToX0Y1()
        {
            m_rover.ExecuteCommand('F');

            Assert.AreEqual(m_rover.X, 0);
            Assert.AreEqual(m_rover.Y, 1);
        }

    }
}
