namespace StaticogIkkestatic;

public class Places
{
    public string PlaceName { get; private set; }
    public string Municipality{ get; private set; }
    public string Region{ get; private set; }

    public Places(string placeName, string municipality, string region)
    {
        PlaceName = placeName;
        Municipality = municipality;
        Region = region;
    }
    public void ShowPlace()
    {
        var labelWidth = 8;
        ShowSeperatorRow();
        ShowFielAndValue("Navn", labelWidth,PlaceName);
        ShowFielAndValue("Kommune", labelWidth,Municipality);
        ShowFielAndValue("Fylke", labelWidth,Region);
        ShowSeperatorRow();
    }

    static void ShowFielAndValue(string label, int labelWidth,string fieldValue)
    {
        labelWidth = label.Length;
        Console.WriteLine("  " + label +":" + String.Empty.PadLeft(labelWidth, ' ') + fieldValue);
    }

    static void ShowSeperatorRow(int labelWidth = 8)
    {
        labelWidth += 14;
        Console.WriteLine(String.Empty.PadLeft(labelWidth, '*'));
    }
}