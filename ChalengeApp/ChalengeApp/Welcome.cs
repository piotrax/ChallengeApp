using System;

public class Welcome
{
	private static int counter = 0;
	private readonly string name = "";

    public Welcome()
    {
        counter++;
        Console.WriteLine($"Witaj NoName po raz {counter}!");
    }
    public Welcome(string name)
	{
		counter++; ;
		Console.WriteLine($"Witaj {name} po raz {counter}!");
	}
}
