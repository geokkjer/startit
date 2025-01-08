namespace Lagerstyringssystem;

public class Elektronikk: IProdukt
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    int Garantitid { get; set; }

    public Elektronikk(string navn, double pris, int garantitid)
    {
        Navn = navn;
        Pris = pris;
        Garantitid = garantitid;
    }
    public void SkrivUtInfo() {
        Console.WriteLine($"Navn: {this.Navn}\nPris: {Pris}\nGarantitid: {Garantitid}"); 
    }
}