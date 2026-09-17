namespace Rover.Tests
{ 
    public class InitialiseRoverTests
    {
        [Test]
        public void InitializingRoverAtPositionAndDirectionInitializesPosition()
        {
            var location = (5, 6);
            Rover rover = new Rover(location);
            Assert.That(rover.Location, Is.EqualTo(location));
        }
    }

    public class Rover
    {
        public (int, int) Location { get; }

        public Rover((int, int) location)
        {
            Location = location;
        }
    }
}