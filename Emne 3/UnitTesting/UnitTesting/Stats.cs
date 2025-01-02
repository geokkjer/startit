using System.Security;

namespace UnitTesting;

public class Stats
{
    public int Count {get; private set;}
    public int Sum {get; private set;}
    public int? Max { get; private set; }
    public int? Min {get; private set;}
    public float Mean => (float)Sum / Count;

    public void Add(int number)
    {
        if (Max == null || number > Max) Max = number;
        if (Min == null || number < Min) Min = number;
        Count++;
        Sum += number;
    }

    public string GetDescription()
    {
        return
            Format("Antall tall", Count) +
            Format("Sum", Sum) +
            Format("Max", Max.Value) +
            Format("Min", Min.Value) +
            Format("Gjennomsnitt", Mean);
            
    }

    private static string Format(string label, float? number)
    {
        if (number == null) return String.Empty;
        return FormatImpl(label, number.Value.ToString("####.##"));
    }

    private static string Format(string label, int? number)
    {
        if (number == null) return String.Empty;
        return FormatImpl(label, number.Value.ToString("####"));
    }

    private static string FormatImpl(string label, string number)
    {
        return label.PadRight(12, ' ') + ": " + number + '\n';
    }
    
    
}