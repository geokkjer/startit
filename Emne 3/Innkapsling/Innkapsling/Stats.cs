namespace Innkapsling;

public class Stats
{
    private int[] _numbers;
    private int _numberCount;

    public Stats()
    {
        _numbers = new int[10];
    }

    public void AddNumber(int number)
    {
      _numbers[_numberCount] = number;
      _numberCount++;  
    }

    public void Show()
    {
        var sum = _numbers.Sum();
        Console.Clear();
        Console.WriteLine(
            $"Antall tall: {_numberCount} " +
            $"Sum: {sum} " +
            $"Snitt: {(float)sum / _numberCount}"
            );
    }
}