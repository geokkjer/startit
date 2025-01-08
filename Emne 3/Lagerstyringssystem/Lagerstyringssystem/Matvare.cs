namespace Lagerstyringssystem;

public class Matvare: IProdukt
{
    public string Navn { get; set; }

    public double Pris { get; set; }
    public DateTime Utløpsdato { get; set; }
    
    public void SkrivUtInfo()
    {
        throw new NotImplementedException();
    }
}