namespace Lagerstyringssystem;

public class Elektronikk: IProdukt
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    int Garantitid { get; set; }


    public void SkrivUtInfo() {
        Console.WriteLine($"Navn: {Navn}\nPris: {Pris}\nGarantitid: {Garantitid}"); 
    }
}