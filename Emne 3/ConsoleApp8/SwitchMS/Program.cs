public static class SwitchMS
{
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    }

    public enum Orientation
    {
        North,
        South,
        East,
        West
    }

    public static Orientation ToOrientation(Direction direction) => direction switch
    {
        Direction.Up => Orientation.North,
        Direction.Right => Orientation.East,
        Direction.Down => Orientation.South,
        Direction.Left => Orientation.West,
        _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
    };

    public static void Main()
    {
    var direction = Direction.Up;
    Console.WriteLine($"Map view direction is {direction}");
    Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}");
       
    }
}