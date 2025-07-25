using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}