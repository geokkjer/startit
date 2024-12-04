/* Du skal lage en oppskriftsapp der brukeren kan velge å:
   Se alle oppskrifter som er tilgjengelig,
   Filtrere oppskrift basert på kategori; ex vegetar, helgekos,
   Filtrere oppskriftene ved å søke etter oppskrifter som inneholder en spesifikk ingrediens
   Brukeren skal kunne velge å se nærmere på en oppskrift for å få ingredienser og fremgangsmetode
*/
using CodeAlong0412;

var dish1 = new Dish("Bread", "Loff", ["Mel","Vann","Smør"]);
var dish2 = new Dish("Grøt","Rømmegrøt",["Ris","Rømme","Melk","Smør"]);
var dishList = {dish1, dish2};


var running = true;

while (running)
{
   Console.Clear();
   Console.WriteLine("Welcome to the Dishshower!!");
   Console.WriteLine("1. Dish List");
   var input = Console.ReadLine();
   switch(input)
   {
      case "1":
         foreach (var dish in dishList)
         {
           Console.WriteLine(dish.NameOfDish);
         }
         Console.WriteLine();
         break;
      case "2":
         //var input = Console.ReadLine();
         //SearchIngredients();
         break;
   }
}

