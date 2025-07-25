using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {num1 + num2}");
                break;

            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;

            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;

            case "/":
                if (num2 != 0)
                Console.WriteLine($"Result: {num1 / num2}");
                else
                Console.WriteLine("Cannot divide by zero.");
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}