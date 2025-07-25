using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if  (int.TryParse(input, out int number))
        {
            int result = number + 10;
            Console.WriteLine($"Result after adding 10: {result}");
        }
        else
        {
            Console.WriteLine("Reject non-numeric input");
        }
    }
}