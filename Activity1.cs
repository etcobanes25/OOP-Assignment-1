internal class Program
{
    private static void Main(string[] args)
    {
        string Firstname, Lastname;

        Console.Write("Firstname :");
        Firstname = Console.ReadLine();

        Console.Write("Lastname :");
        Lastname = Console.ReadLine();

        if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Lastname))
        {

            Console.WriteLine("Firstname and Lastname. Please fill in.");
        }
        else
        {
            Console.WriteLine($"Your full name is: {Firstname}, {Lastname}");
        }
    }
}