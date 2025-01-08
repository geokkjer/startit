namespace Lagerstyringssystem;

public class Lager
{
    public Lager(List<IProdukt> inventar)
    {
        Inventar = inventar;
    }

    public List<IProdukt> Inventar { get; set; }

    public void Add(IProdukt produkt)
    {
        Inventar.Add(produkt);
    }

    public void Remove(IProdukt produkt)
    {
        Inventar.Remove(produkt);
    }

    public void ListAll()
    {
        foreach (IProdukt produkt in Inventar)
        {
            produkt.SkrivUtInfo();
        }
    }
    
}