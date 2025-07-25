using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Check if input is not empty and contains only letters
        if (!string.IsNullOrWhiteSpace(name) && IsAllLetters(name))
        {
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            Console.WriteLine("Formatted name: " + formattedName);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-empty name with alphabetic characters only.");
        }
    }

    // Function to check if all characters are letters
    public static bool IsAllLetters(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
}