using Microsoft.Win32.SafeHandles;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Misio!");
        string tekst = "coś tam";
        Console.WriteLine(tekst);
        byte max = byte.MaxValue;
        byte min = byte.MinValue;
        Console.Write("Podaj liczbę od 0 do 255: ");
        int liczba = int.Parse(Console.ReadLine());
        if (liczba >= min && liczba <= max)
        {
            Console.WriteLine($"Liczba {liczba} mieści się w zakresie jednego bajta");
        }
        else
        {
            Console.WriteLine($"Liczba {liczba} nie mieści się w zakresie jednego bajta");
        }

        Console.Write("Jak się nazywasz? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Maksymalna wartość bajtu wynosi {max}, minimalna wynosi {min}.");
        var witaj = new Welcome(name);
    }
}