namespace ObjekterIListe
{
    class Program
    {
        static public void AddPeople()
        {
            List<Person> people = new List<Person>();      
            Person person1  = new Person("Alice", "Smith", 25);
            Person person2  = new Person("Bob", "Jones", 37);
            Person person3  = new Person("Charlie", "Jones", 28);
            
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            WriteToConsole(people);
             
        }
        static void WriteToConsole(this List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                 Console.WriteLine($"Fornavn: {people[i].FirstName}\nEtternavn: {people[i].LastName}\nAlder: {people[i].Age}");
            } 
        }
        static void Main(string[] args){
            AddPeople();
        }
    }
}