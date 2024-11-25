namespace ObjekterIListe;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    // Constructor
    public Person(string firstName, string lastName, int Age)
    {
        firstName = firstName;
        lastName = lastName;
        Age = Age;
    }
}