namespace TowersOfHanoiTerje;

internal class Disc
{
    private readonly int _size;

    public Disc(int size)
    {
        _size = size;
    }

    public void Show()
    {
        var col = 1 + (columnNo - 1) * 15;
    }
}