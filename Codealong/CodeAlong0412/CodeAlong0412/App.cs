namespace CodeAlong0412;

public class App
{
    List<Dish> _dish;
    
    public App()
    {
        _dish = new List<Dish>()
        {
            new Dish("Brød", "Loff", ["Mel",]),
            new Dish("Grøt", "Rømmegrøt", ["Milk","Rømme","Ris"]),
            new Dish("Pannekaker","Pannekaker er godt", ["Milk","Mel","Egg","Sukker"]),
        };
        AppMenu();
    }

    void AppMenu()
    {
        var running = true;
        while (running)
        {
           //Console.Clear();
           Console.WriteLine("Welcome to the Dishshower!!");
           Console.WriteLine("1. Dish List");
           var input = Console.ReadLine();
           switch(input)
           {
              case "1":
                 ShowDishNames();
                 Thread.Sleep(10000);
                 break;
              case "2":
                 //var input = Console.ReadLine();
                 //SearchIngredients();
                 running = false;
                 break;
           }
        }
    }

    private void ShowDishNames()
    {
        foreach (var dish in _dish)
        {
            Console.WriteLine(dish.NameOfDish);
        }
        Console.WriteLine(":-D");
    }
}