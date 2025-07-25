using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 0 && age <= 130)
        {
            if (age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("Teen");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }
        }
        else
        {
            Console.WriteLine("Invalid age.");
        }
    }
}