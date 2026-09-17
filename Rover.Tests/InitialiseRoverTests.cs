namespace Rover.Tests
{ 
    public class InitialiseRoverTests
    {
        [Test]
        public void InitializingRoverAtPositionAndDirectionInitializesPosition()
        {
            var location = (5, 6);
            Rover rover = new Rover(location, CardinalDirection.East);
            Assert.That(rover.Location, Is.EqualTo(location));
        }

        [Test]
        public void InitializingRoverAtPositionAndDirectionInitializesDirection()
        {
            Rover rover = new Rover ((5, 6), CardinalDirection.East);

            Assert.That(rover.Direction, Is.EqualTo(CardinalDirection.East));
        }
    }
}