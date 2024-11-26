namespace Clicker;

internal class Clicker
{
    public int Points;
    public int Upgrades;
    public char Character;

    public Clicker(char character)
    {
        Upgrades = 1;
        Points = 0;
        Character = character;
    }

    public void Show()
    {
        Console.Clear();
        Console.WriteLine($"Clicker Simple. Du har {Points} points.");
    }

    public void HandleCommand(ConsoleKey cmdKey)
    {
        
    }
    
}