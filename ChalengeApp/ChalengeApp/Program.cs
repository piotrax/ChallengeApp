internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Misio!");
        string tekst = "coś tam";
        Console.WriteLine(tekst);
        byte bajt = byte.MaxValue;
        byte bajt2 = byte.MinValue;

        Console.Write("Jak się nazywasz? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Maksymalna wartość bajtu wynosi {bajt}, minimalna wynosi {bajt2}.");
        var witaj = new Welcome(name="NoName");
    }
}