using ChallengeApp;
using System.Net;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program oceny pracowników w firmie XYZ");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine();

        var employee = new Employee("Master", "Of Disaster", "M");

        while (true)
        {
            Console.Write("Podaj kolejną ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q") break;
            try
            {
                employee.AddGrade(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min:N2}");
        Console.WriteLine($"Max: {statistics.Max:N2}");
        Console.WriteLine($"Avg: {statistics.Average:N2}");
        Console.WriteLine($"Average letter: {statistics.AverageLetter}");
        foreach (var item in employee.grades) Console.Write(item + " ");

    }
}
