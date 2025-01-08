namespace Lagerstyringssystem;

public class Klær: IProdukt
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    public string Størrelse { get; set; }

    public Klær(string navn, double pris, string størrelse)
    {
        Navn = navn;
        Pris = pris;
        Størrelse = størrelse;
    }

    public void SkrivUtInfo()
    {
        
        Console.WriteLine($"Navn: {this.Navn}\nPris: {Pris}\nStørrelse: {Størrelse}"); 
    }
}