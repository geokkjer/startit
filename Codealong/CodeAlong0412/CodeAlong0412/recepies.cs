namespace CodeAlong0412;

public class Dish
{
    public int DishId { get; set; }
    public string NameOfDish { get; set; }
    public string DescriptionOfDish { get; set; }
    public string[] Ingredients { get; set; }
    public string[] Categories { get; set; }

    public Dish(int id,string name, string description, string[] ingredients, string[] categories)
    {
        DishId = id;
        NameOfDish = name;
        DescriptionOfDish = description;
        Ingredients = ingredients;
        Categories = categories;
    }

    public void ShowDishWithIngredients()
    {
        Console.WriteLine($"\nNavn: {NameOfDish}\nBeskrivelse: {DescriptionOfDish}\n");
        Console.WriteLine($"Ingredients: \n{GetIngredients(Ingredients)}");
    }

    public string GetIngredients(string[] ingredientArray)
    {
        var items = "";
        foreach (var ingredient in ingredientArray)
        {
          items += ingredient + "\n"; 
        } ;
        return items;
    }
    public void ShowDishByIngredients()
    {
        Console.Clear();
        Console.WriteLine("Tilgjengelige ingredienter: ");
        Console.WriteLine(GetIngredients(Ingredients));
        
    } 
    public void ShowDishByCategoryMenu() 
    {
        Console.Clear();
    }    
}
// search
