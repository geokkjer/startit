namespace Clicker;

public class Person
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Person(string name, int points)
    {
        Name = name;
        Points = points;
    }
}