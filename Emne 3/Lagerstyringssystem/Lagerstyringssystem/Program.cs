using Lagerstyringssystem;

var lager = new Lager([]);
lager.Inventar.Add(new Elektronikk("Radio",666,36));
lager.Inventar.Add(new Elektronikk("Tv",10500,36));
lager.Inventar.Add(new Elektronikk("Laptop",7777,36));
lager.Inventar.Add(new Klær("Jeans",888,"Xl"));
lager.Inventar.Add(new Klær("Jakke", 765,"L"));
lager.Inventar.Add(new Klær("Skjorte",567,"S"));
lager.Inventar.Add(new Matvare("Ost",109,new DateTime(2025,01,30)));
lager.Inventar.Add(new Matvare("Pizza",79,new DateTime(2025,01,22)));
lager.Inventar.Add(new Matvare("Egg",49,new DateTime(2025,02,17)));
var itemToRemove =lager.Inventar.Find(x => x.Navn == "Egg");
if (itemToRemove != null)
{
    lager.Inventar.Remove(itemToRemove);
}


lager.ListAll();