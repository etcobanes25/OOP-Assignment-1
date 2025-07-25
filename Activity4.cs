internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius:");
        string input = Console.ReadLine();

        float celsius = float.Parse(input);

        if (celsius >= -100 && celsius <= 100)
        {
            float fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine("Temperature in Fahrenheit:" + fahrenheit);
        }
        else
        {
            Console.WriteLine("Input must be between -100 and 100.");
        }
    }
}