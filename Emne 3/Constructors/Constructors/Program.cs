namespace Constructors
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public Person(String name, Int32 age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("John", 19);
            Console.WriteLine($"Navn: {person1.Name}, Alder: {person1.Age}");
        }
    }
}