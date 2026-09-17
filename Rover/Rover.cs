namespace Rover;
public class Rover
{
    public (int, int) Location { get; }
    public CardinalDirection Direction { get; }

    public Rover((int, int) location, CardinalDirection direction)
    {
        Direction = direction;
        Location = location;
    }
}