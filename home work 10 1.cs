class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first and last name:");
        string[] nameParts = Console.ReadLine().Split(' ');

        if (nameParts.Length < 2)
        {
            Console.WriteLine("Please enter both your first and last name.");
            return;
        }

        if (nameParts[0][0] == nameParts[1][0])
            Console.WriteLine("The last name starts with the same letter as the first name.");
        else
            Console.WriteLine("The last name does not start with the same letter as the first name.");
    }
}