using ChallengeApp;

class Program
{
    private static void Main(string[] args)
    {   
        List<Employee> employees = new List<Employee>(); // pusta lista pracowników
        employees.Add(new Employee("Adam", "Abacki", 33)); // imie, nazwisko, wiek
        employees.Add(new Employee("Adam", "Abacki", 33));
        employees.Add(new Employee("Beata", "Babacka", 44));
        employees.Add(new Employee("Cezary", "Cabacki", 22));
        employees.Add(new Employee("Dorota", "Dabacka", 55));
        Random rand = new Random(); // utworzenie generatora liczb losowych

        foreach (Employee employee in employees)
        {
            for (int i = 0; i < 5; i++)
            {
                employee.AddScore(rand.Next(1, 11)); // losowe oceny od 1 do 10
            }
        }

        int maxScore = 0;
        string maxName = "";
        string maxSurname = "";
        for(int i = 0;i < employees.Count; i++)
        {
            if (maxScore < employees[i].Score.Sum())
            {
                maxScore = employees[i].Score.Sum();
                maxName = employees[i].Name;
                maxSurname = employees[i].Surname;
            }

        }
        Console.WriteLine($"Pracownik z najwyższą liczbą ocen ({maxScore}) to {maxName} {maxSurname}.");
    }
}
