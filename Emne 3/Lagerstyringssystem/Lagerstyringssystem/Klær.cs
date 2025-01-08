namespace Lagerstyringssystem;

public class Klær: IProdukt
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    public string Størrelse { get; set; }
    
    public void SkrivUtInfo()
    {
        throw new NotImplementedException();
    }
}