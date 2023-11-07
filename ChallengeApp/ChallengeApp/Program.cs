using ChallengeApp;
using System.Net;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program oceny pracowników w firmie XYZ");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

        var employee = new EmployeeInFile("Master", "Of Disaster");
        try
        {
            employee.AddGrade(41.2f);
            employee.AddGrade("B");
            employee.AddGrade("E");
            employee.AddGrade('A');
            employee.AddGrade('f');
            employee.AddGrade(11f);
            employee.AddGrade(52f);
            employee.AddGrade(1.2f);
            employee.AddGrade("d");
            employee.AddGrade("c");
            employee.AddGrade(66f);
            employee.AddGrade(33.33f);

            var statistics = employee.GetStatistics();
            Console.WriteLine($"\nMin: {statistics.Min:N2}");
            Console.WriteLine($"Max: {statistics.Max:N2}");
            Console.WriteLine($"Avg: {statistics.Average:N2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //var supervisor = new Supervisor("Anna", "Jantar", "W");

        //while (true)
        //{
        //    Console.Write("Podaj kolejną ocenę pracownika: ");
        //    var input = Console.ReadLine();
        //    if (input == "q") break;
        //    try
        //    {
        //        employee.AddGrade(input);
        //        //supervisor.AddGrade(input);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Exception: {ex.Message}");
        //    }
        //}
        //var statistics = employee.GetStatistics();
        ////var statistics = supervisor.GetStatistics();
        //Console.WriteLine($"Min: {statistics.Min:N2}");
        //Console.WriteLine($"Max: {statistics.Max:N2}");
        //Console.WriteLine($"Avg: {statistics.Average:N2}");
        //Console.WriteLine($"Average letter: {statistics.AverageLetter}");
        //foreach (var item in employee.grades) Console.Write(item + " ");
        ////foreach (var item in supervisor.grades) Console.Write(item + " ");
    }
}
