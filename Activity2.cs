using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your age in years: ");
        int ageInYears = Convert.ToInt32(Console.ReadLine());

        if (ageInYears >= 1 && ageInYears <= 120)
        {
            int ageInMonths = ageInYears * 12;
            Console.WriteLine($"You are {ageInMonths} months old.");
        }
        else
        {
            Console.WriteLine("Please enter a valid age between 1 and 120.");
        }
    }
    }