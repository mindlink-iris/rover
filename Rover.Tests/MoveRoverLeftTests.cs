namespace Rover.Tests
{ 
    public class MoveRoverLeftTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Rover rover = new Rover((0, 0), CardinalDirection.North);
            rover.TurnLeft();
            Assert.That(rover.Direction, Is.EqualTo(CardinalDirection.West));
        }
    }
}