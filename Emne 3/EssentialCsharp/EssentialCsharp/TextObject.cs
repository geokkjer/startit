namespace EssentialCsharp;

public class TextObject
{
    public string Text { get; set; }
    public int FontSize { get; set; }
    public int FontColor { get; set; }
    public ConsoleColor Color { get; set; }
    
    public void Print()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Text);
        Console.WriteLine(FontSize);
        Console.WriteLine(FontColor);
        
        
    }
}