using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        int.TryParse(Console.ReadLine(), out int total);

        double percentage = (double)marks / total * 100;

        Console.WriteLine("Percentage: " + percentage);
    }
}