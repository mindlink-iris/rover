namespace Rover;
public class Rover
{
    public (int, int) Location { get; }
    public CardinalDirection Direction { get; private set; }

    public Rover((int, int) location, CardinalDirection direction)
    {
        Direction = direction;
        Location = location;
    }

    public void TurnLeft()
    {
        if (Direction == CardinalDirection.North)
        {
            Direction = CardinalDirection.West;
        }
    }
}