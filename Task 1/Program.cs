class Program
{
    static void Main(string[] args)
    {
        // Creating first object
        Student s1 = new Student();
        s1.name = "Subu";
        s1.age = 21;
        s1.department = "Computer Science";

        // Creating second object
        Student s2 = new Student();
        s2.name = "Kiyasha";
        s2.age = 20;
        s2.department = "Civil Engineering";

        // Display values of object 1
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Department: " + s1.department);

        Console.WriteLine();

        // Display values of object 2
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Department: " + s2.department);

        Console.WriteLine();

        // Display static field
        Console.WriteLine("College Name (Static Field): " + Student.collegeName);
    }
}