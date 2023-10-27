using Microsoft.Win32.SafeHandles;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Ewa";
        string sex = "kobieta";
        int age = 33;

        if (sex == "kobieta")
        {
            if (age < 30)
            {
                Console.WriteLine($"kobieta  poniżej 30 lat");
            }
            else
            {
                Console.WriteLine($"{name} lat {age}");
            }
        }
        else
        {
            if (age < 18)
            {
                Console.WriteLine("Niepełnoletni Mężczyzna");
            }
            else
            {
                Console.WriteLine($"Mężczyzna lat {age}");
            }
        }
    }
}