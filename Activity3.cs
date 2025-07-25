internal class Program
{
    private static void Main(string[] args)
    {
        int quantity = 10;
        float price = 7.00f;

        float totalCost = quantity * price;

        Console.WriteLine($"Total cost: {totalCost:F2}");

        
    }
}