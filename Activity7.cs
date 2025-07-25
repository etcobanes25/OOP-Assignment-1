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
        char op = char.Parse(Console.ReadLine());

        float result;

        if      (op == '+') result = num1 + num2;
        else if (op == '-') result = num1 - num2;
        else if (op == '*') result = num1 * num2;
        else if (op == '/')
        {
             if (num2 != 0)
                result = num1 / num2;
            else
            {
            Console.WriteLine("Error: Cannot divide by zero.");
                return;
            }
        }
            else
        {
            Console.WriteLine("Invalid operator.");
            return;
        }

            Console.WriteLine($"The result is: {result}");
    }
}