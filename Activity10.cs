using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        if (name == "")
        {
            Console.WriteLine("Name must not be empty.");
        }
        else if (age < 1 || age > 120)
        {
            Console.WriteLine("Invalid age.");
        }
        else if (!email.Contains("@"))
        {
            Console.WriteLine("Invalid email.");
        }
        else
        {
            Console.WriteLine("All are valid.");
        }
    }
}