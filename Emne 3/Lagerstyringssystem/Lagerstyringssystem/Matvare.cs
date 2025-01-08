namespace Lagerstyringssystem;

public class Matvare: IProdukt
{
    public string Navn { get; set; }

    public double Pris { get; set; }
    public DateTime Utløpsdato { get; set; }

    public Matvare(string navn, double pris, DateTime utløpsdato)
    {
        Navn = navn;
        Pris = pris;
        Utløpsdato = utløpsdato;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Navn: {this.Navn}\nPris: {Pris}\nUtløpsdato: {Utløpsdato}"); 
    }
}