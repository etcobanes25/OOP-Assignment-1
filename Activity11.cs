using System;

public class Program
{
    public static void Main()
    {
        string correctPin = "1234";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter your user pin: ");
            string userPin = Console.ReadLine();

            if (userPin == correctPin)
            {
                Console.WriteLine("Access granted.");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect pin.");
                attempts++;
            }
        }

        Console.WriteLine("Access denied.");
    }
}