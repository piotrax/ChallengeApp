using ChallengeApp;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program oceny pracowników w firmie XYZ");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine();

        var employee = new Employee();

        do
        {
            Console.Write("Podaj kolejną ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q" && employee.grades.Count > 0) break;
            employee.AddGrade(input);
        } while (true);

        var statistics = employee.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min:N2}");
        Console.WriteLine($"Max: {statistics.Max:N2}");
        Console.WriteLine($"Avg: {statistics.Average:N2}");
        Console.WriteLine($"Average letter: {statistics.AverageLetter}");
    }
}
