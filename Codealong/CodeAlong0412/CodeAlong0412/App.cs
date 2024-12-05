namespace CodeAlong0412;

public class App
{
    public List<Dish> Dish { get; set; } 
    public App()
    {
        Dish = new List<Dish>()
        {
            new Dish(1,
                "Loff",
                "Hjemmebakt loff kan spises som den er med litt godt smør og pålegg.", 
                ["Smør","Mel","Gjær","Salt","Melk","Egg", "Valmuefrø"],
                ["Brød","Bakverk","Frokost"]
                ),
            new Dish(2,
                "Rømmegrøt",
                "Rømmegrøt",
                ["Milk","Seterrømme","Mel","Salt"],
                ["Frokost", "Middag"]
                ),
            new Dish(3,
                "Pannekaker",
                "Pannekaker er godt",
                ["Melk","Mel","Egg","Sukker","Salt"],
                ["Middag","Dessert"]),
            new Dish(4,
                "Gulrotrundstykker",
                "Gulrot i deigen gjør rundstykkene saftigere og gir en god smak. De passer fint både i matpakken eller som turmat.",
                ["Melk","Gjær","Mel","Sukker","Salt","Kardemomme","Gulrot"],
                ["Brød","Bakverk", "Lunsj"])
        };
        AppMenu();
    }

    void AppMenu()
    {
        Console.Clear();
        var running = true;
        while (running)
        {
           Console.Clear();
           Console.WriteLine("Velkommen til Oppskrifts appen: ");
           Console.WriteLine("1.) Vis liste over alle oppskriftene:");
           Console.WriteLine("2.) Filtrer på kategori");
           Console.WriteLine("3.) Filtrer på ingrdiensene");
           Console.WriteLine("q. for å avslutte");
           
           
           var input = Console.ReadLine();
           switch(input)
           {
              case "1": 
                  ShowDishNamesMenu(); 
                  break;
              case "2":
                  ShowDishCategoryMenu();
                  break;
              case "3":
                  ShowIngredientsMenu();
                  break;
              case "q":
                 running = false;
                 break;
           }
        }
    }

    private void ShowDishNamesMenu()
    {
        Console.Clear();
        Console.WriteLine("Tilgjengelige oppskrifter: ");
        foreach (var dish in Dish)
        {
            Console.WriteLine($"{dish.DishId}.) {dish.NameOfDish}");
        }
        Console.WriteLine("Velg for å se nærmere beskrivelse. Trykk 0 for å gå tilbake");
        var choice = Convert.ToInt32(Console.ReadLine());
        if (choice != 0){
            ShowDish(choice);
        }
        else
        {
            Console.WriteLine("Skriv ett tall eller 0 for å gå tilbake.");
        }
    }

    public void ShowDish(int id)
    {
        var thisDish = Dish.FirstOrDefault(d => d.DishId == id); 
        Console.WriteLine($"Navn: {thisDish.NameOfDish}\nBeskrivelse: {thisDish.DescriptionOfDish}"); 
        Console.ReadLine();
    }

    public void ShowIngredientsMenu()
    {
        Console.Clear();
        Console.WriteLine("Filtrer basert på ingrediens: ");
        var search = Console.ReadLine();
        var dishes = Dish.Where(d => d.Ingredients.Contains(search));
        Console.WriteLine($"Retter med {search}");
        foreach (var dish in dishes)
        {
            Console.WriteLine($"{dish.NameOfDish} - {dish.DescriptionOfDish}");
        }
        Console.WriteLine("Trykk for å gå tilbake");
        Console.ReadKey();

    }

    void ShowDishCategoryMenu()
    {
           Console.Clear();
           Console.WriteLine("Filtre basert på kategori: ");
           Console.WriteLine("Kategorier: Middag - Forkost - Lunsj - Dessert - Bakverk");
           var input = Console.ReadLine();
           var dish = Dish.Where(d => d.Categories.Contains(input));
           Console.WriteLine($"Retter i {input} kategorien");
           foreach (var d in dish)
           {
               Console.WriteLine($"{d.NameOfDish} - {d.DescriptionOfDish}");
           }

           Console.ReadKey();
    }
    
}

    
