namespace Lagerstyringssystem;

public class Lager
{
    List<IProdukt> Inventar { get; set; }

    void Add(IProdukt produkt)
    {
        Inventar.Add(produkt);
    }

    void Remove(IProdukt produkt)
    {
        Inventar.Remove(produkt);
    }

    void ListAll(List<IProdukt> inventar)
    {
        foreach (IProdukt produkt in inventar)
        {
            produkt.SkrivUtInfo();
        }
    }
    
}