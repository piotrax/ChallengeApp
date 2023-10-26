using System;

public class Welcome
{
	string word { get; set; }
	public Welcome(string name)
	{
		this.word = "Witaj";
		if (name.Length == 0)
		{
			Console.WriteLine($"{this.word} NoName!");
		}
		else
		{
			Console.WriteLine($"{this.word} {name}!");
		}
	}
}
