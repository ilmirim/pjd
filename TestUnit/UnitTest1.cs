using System.Drawing;
using Game;
using Newtonsoft.Json.Linq;

namespace TestUnit
{
    public class Tests
    {
        private Player entity;
        [SetUp]
        public void Setup()
        {
            entity = new Player(15, 15, Point.Empty, new Figure(), new Figure(), 25);
        }

        [TestCase(123, 6346)]
        [TestCase(-456, 67546)]
        [TestCase(987, 29998)]
        public void BoardSize(int valueX, int valueY)
        {
            entity.Position = new Point(valueX, valueY);
            var value = entity.Position;
            Assert.IsFalse(value.X < 1240 && value.Y < 655 && value.X > 0 && value.Y > 0);
        }
        [Test]
        public void Test1()
        {
            var entity = new Entity(10);
            var figure = new Figure(10);
            Assert.IsTrue(figure.Size>0);
            Assert.IsTrue(entity.Speed > 0);
        }
    }
}