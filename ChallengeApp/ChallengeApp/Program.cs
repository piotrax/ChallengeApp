using ChallengeApp;

class Program
{
    private static void Main(string[] args)
    {
        var employee1 = new Employee("Peter", "Parker");
        employee1.AddGrade(0xa);
        employee1.AddGrade(-0b11);
        employee1.AddGrade(-0xc);
        employee1.AddGrade(1/0);
        employee1.AddGrade(11*2);


        var statistics = employee1.GetStatistics();
        Console.WriteLine($"Min: {statistics.Min:N0}");
        Console.WriteLine($"Max: {statistics.Max:N0}");
        Console.WriteLine($"Avg: {statistics.Average:N2}");

    }
}
