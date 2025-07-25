using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your grade: ");
        int grade = int.Parse(Console.ReadLine());

        char letter;

            if (grade >= 0 && grade <= 100)
        {
            if      (grade >= 90 && grade <= 100) letter = 'A';
            else if (grade >= 80 && grade <= 89)  letter = 'B';
            else if (grade >= 70 && grade <= 79)  letter = 'C';
            else if (grade >= 60 && grade <= 69)  letter = 'D';
            else letter = 'F';

            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
    }
}