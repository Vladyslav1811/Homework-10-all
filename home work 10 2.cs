using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder report = new StringBuilder();

        report.AppendLine("Event Report");
        report.AppendLine("Date: " + DateTime.Now.ToShortDateString());
        report.AppendLine("--------------------------");

        Console.WriteLine("Enter events. Type 'done' to finish.");

        while (true)
        {
            Console.Write("Enter event: ");
            string eventInput = Console.ReadLine();

            if (eventInput == "done")
            {
                break;
            }

            report.AppendLine("- " + eventInput);
        }

        Console.WriteLine("\nYour report:");
        Console.WriteLine(report.ToString());
    }
}