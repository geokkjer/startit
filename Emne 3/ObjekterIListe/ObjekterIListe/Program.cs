namespace ObjekterIListe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("Alice", "Smith", 25),
                new Person("Bob", "Jones", 37),
                new Person("Charlie", "Jones", 28)
            };
            people.ForEach(p => Console.WriteLine($"Navn: {p.FirstName} {p.LastName}\nAlder: {p.Age}"));
        }
    }
}