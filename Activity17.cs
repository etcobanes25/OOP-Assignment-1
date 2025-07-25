using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number (1 to 10): ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
            Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Number must be between 1 and 10.");
        }
    }
}