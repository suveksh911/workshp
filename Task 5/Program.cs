class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day (Example: Sunday): ");
        string inputDay = Console.ReadLine().Trim().ToLower();

        DayType type;

        if (inputDay == "friday" || inputDay == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);
        Console.WriteLine();

        Book book1 = new Book("War and Peace", "Leo Tolstoy", 799.0);

        Book book2 = book1 with { title = "Advanced C#", price = 988.99 };

        Console.WriteLine("Book 1:");
        Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

        Console.WriteLine();

        var (title, author, price) = book2;

        Console.WriteLine("Book 2 (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}