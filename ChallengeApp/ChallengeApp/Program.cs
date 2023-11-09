using ChallengeApp;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program oceny pracowników w firmie XYZ");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

        var employee = new EmployeeInFile("Jack", "Sparrow");
        employee.GradeAdded += employee.EmployeeGradeAdded;

        employee.AddGrade(12f);
        employee.AddGrade('C');
        employee.AddGrade("d");
        employee.AddGrade(22d);
        employee.AddGrade(44l);
        employee.AddGrade(23.32);

        //while (true)
        //{
        //    Console.Write("Podaj kolejną ocenę pracownika: ");
        //    var input = Console.ReadLine();
        //    if (input.ToLower() == "q") break;
        //    try
        //    {
        //        employee.AddGrade(input);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Exception: {ex.Message}");
        //    }
        //}
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min:N2}");
        Console.WriteLine($"Max: {statistics.Max:N2}");
        Console.WriteLine($"Avg: {statistics.Average:N2}");
        Console.WriteLine($"Average letter: {statistics.AverageLetter}");

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write("Wszystkie oceny: ");
        //foreach (var item in employee.grades) Console.Write(item + " ");
        //Console.ForegroundColor = ConsoleColor.White;
    }
}
