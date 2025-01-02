using System.Security;

namespace UnitTesting;

public class Stats
{
    public int Count {get; private set;}
    public int Sum {get; private set;}
    public int Max {get; private set;}
    public int Min {get; private set;}
    public float Mean => (float)Sum / Count;

    public void Add(int number)
    {
        if (Max == -1 || number > Max) Max = number;
        if (Min == -1 || number < Min) Min = number;
        Count++;
        Sum += number;
    }

    public string GetDescription()
    {
        return
            Format("Antall tall", Count) +
            Format("Sum", Sum) +
            Format("Max", Max) +
            Format("Min", Min) +
            Format("Gjennomsnitt", Mean);
            
    }

    private static string Format(string label, float number)
    {
        return FormatImpl(label, number.ToString("####.##"));
    }

    private static string Format(string label, int number)
    {
        return FormatImpl(label, number.ToString("####"));
    }

    private static string FormatImpl(string label, string number)
    {
        return label.PadRight(12, ' ') + ": " + number + '\n';
    }
    
    
}