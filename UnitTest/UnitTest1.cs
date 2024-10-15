using Game;
using System.Drawing;

namespace UnitTest
{
    public class Tests
    {
        private Player entity;
        [SetUp]
        public void Setup()
        {
            entity = new Player(1280, 720, Point.Empty, new Figure(), new Figure(), 5);
        }

        [TestCase(21341, 411)]
        [TestCase(-222, 411)]
        [TestCase(8335, 0)]
        public void CheckBoard(int valueX, int valueY)
        {
            entity.Position = new Point(valueX, valueY);
            var value = entity.Position;
            Assert.IsFalse(value.X < 1240 && value.Y < 655 && value.X > 0 && value.Y > 0);
        }
        [Test]
        public void CheckZeroValues()
        {
            var entity = new Entity(0);
            var figure = new Figure(0);
            Assert.IsTrue(figure.Size > 0);
            Assert.IsTrue(entity.Speed > 0);
        }
        [TestCase(-1231)]
        [TestCase(-1)]
        public void CheckNegativeValues(int val)
        {
            var entity = new Entity(val);
            var figure = new Figure(val);
            Assert.IsTrue(entity.Speed > 0);
            Assert.IsTrue(figure.Size > 0);
        }
    }
}