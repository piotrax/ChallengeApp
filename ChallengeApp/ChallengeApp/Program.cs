using ChallengeApp;

class Program
{
    private static void Main(string[] args)
    {
        var employee1 = new Employee("Peter", "Parker");
        employee1.AddGrade(0xa);
        employee1.AddGrade("14");
        employee1.AddGrade((byte)2);
        employee1.AddGrade(1/2);
        employee1.AddGrade(3*2);


        var statistics = employee1.GetStatistics();
        var statistics2 = employee1.GetStatisticsWithForEach();
        var statistics3 = employee1.GetStatisticsWithDoWhile();
        var statistics4 = employee1.GetStatisticsWithWhile();
        Console.WriteLine($"Min: {statistics.Min:N0}");
        Console.WriteLine($"Max: {statistics.Max:N0}");
        Console.WriteLine($"Avg: {statistics.Average:N2}");

    }
}
