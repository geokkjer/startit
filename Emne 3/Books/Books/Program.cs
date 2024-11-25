namespace Books
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "John Doe";
            book.Title= "Hello World!";
            book.ShowInfo();
        }
    }
}