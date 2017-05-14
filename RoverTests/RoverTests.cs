using System;
using Mars_Rover_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoverTests
{




    [TestClass]
    public class RoverTests
    {
        private const char FORWARD_COMMAND = 'F';
        private const char BACKWARD_COMMAND = 'B';
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
            m_rover.ExecuteCommand(FORWARD_COMMAND);

            Assert.AreEqual(0, m_rover.X);
            Assert.AreEqual(1, m_rover.Y);
        }

        [TestMethod]
        public void GivenARoverInX0Y0AndInNorthDirection_WhenMoveBackwards_ItGoesToX0YMinus1()
        {
            m_rover.ExecuteCommand(BACKWARD_COMMAND);

            Assert.AreEqual(0, m_rover.X);
            Assert.AreEqual(-1, m_rover.Y);
        }

        [TestMethod]
        public void GivenARoverInX0Y0AndInEastDirection_WhenMoveForward_ItGoesToX1Y0()
        {
            Rover rover = new Rover(0, 0, 'E');

            rover.ExecuteCommand(FORWARD_COMMAND);

            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(0, rover.Y);
        }

        [TestMethod]
        public void GivenARoverInX0Y0InEastDirection_WhenMoveBackwards_ItGoesToXMinus1Y0()
        {
            Rover rover = new Rover(0, 0, 'E');

            rover.ExecuteCommand(BACKWARD_COMMAND);

            Assert.AreEqual(-1, rover.X);
            Assert.AreEqual(0, rover.Y);
        }

        [TestMethod]
        public void GivenARoverInX1Y1InNorthDirection_WhenMoveForward_ItGoesToX1Y2()
        {
            Rover rover = new Rover(1, 1, 'N');

            rover .ExecuteCommand(FORWARD_COMMAND);

            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(2, rover.Y);
        }
    }
}
