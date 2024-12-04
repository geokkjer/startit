namespace CodeAlong0412;

public class Dish
{
        
    public string NameOfDish { get; set; }
    public string DescriptionOfDish { get; set; }
    public string[] Ingredients { get; set; }

    public Dish(string name, string description, string[] ingredients)
    {
        NameOfDish = name;
        DescriptionOfDish = description;
        this.Ingredients = ingredients;
    }

    public void ShowDish()
    {
        Console.WriteLine($"\nNavn: {NameOfDish}\nBeskrivelse: {DescriptionOfDish}\n");
        Console.WriteLine($"Ingredients: \n{ShowIngredients(Ingredients)}");
    }

    public string ShowIngredients(string[] ingredientArray)
    {
        var items = "";
        foreach (var ingredient in ingredientArray)
        {
          items += ingredient + "\n"; 
        } ;
        return items;
    }
    
    
}

// search
