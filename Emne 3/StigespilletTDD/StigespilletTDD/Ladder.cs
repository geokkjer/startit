namespace StigespilletTDD;

public class Ladder
{
    public int PositionFrom { get; set; }
    public int PositionTo { get; set; }

    public Ladder(int positionFrom, int positionTo)
    {
        PositionFrom = positionFrom;
        PositionTo = positionTo;
    }
}