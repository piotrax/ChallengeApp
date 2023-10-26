using System;

public class Welcome
{
	string word { get; set; }
	public Welcome(string name)
	{
		this.word = "Witaj";
		Console.WriteLine($"{this.word} {name}!");
	}
}
