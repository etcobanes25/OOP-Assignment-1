using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 0)
        {
            while (number >= 0)
            {
            Console.WriteLine(number);
                number--;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}