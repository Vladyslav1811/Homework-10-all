class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a comma-separated string:");
            string input = Console.ReadLine();
            
            string result = input.Replace(" ", "");
            
            Console.WriteLine("Result without spaces:");
            Console.WriteLine(result);
        } 
    }