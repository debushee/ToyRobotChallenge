using NUnit.Framework;
using WpfNetCoreRobot.ViewModels;

namespace WpfNetCoreRobot.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Move_One_Y_Coordinate()
        {
            var ToyRobot = new ShellViewModel();
            var Comm = new Commands();
            foreach (var coo in ToyRobot.Coords)
            {
                Comm.Move(coo);
                Assert.AreEqual((0, 1, Pole.NORTH), (coo.X,coo.Y,coo.Pole));
            }
            
        }

        [Test]
        public void Should_Not_Move_Off_Grid()
        {
            var ToyRobot = new ShellViewModel();
            var Comm = new Commands();
            foreach (var coo in ToyRobot.Coords)
            {
                Comm.Move(coo);
                Comm.Move(coo);
                Comm.Move(coo);
                Comm.Move(coo);
                Comm.Move(coo);
                Assert.AreEqual((0, 4, Pole.NORTH), (coo.X, coo.Y, coo.Pole));
            }

        }
    }
}