public class Program
    {
        public static void Main()
        {
            Console.Write("Enter your grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 0 && grade <= 100)
            {
                string letter;

                if (grade >= 90) letter = "A";
                else if (grade >= 80) letter = "B";
                else if (grade >= 70) letter = "C";
                else if (grade >= 60) letter = "D";
                else letter = "F";

                Console.WriteLine($"Your grade: {letter}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }