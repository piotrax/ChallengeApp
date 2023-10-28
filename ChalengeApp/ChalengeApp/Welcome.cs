using System;

public class Welcome
{
	public string Word { get; set; }
	public Welcome(string name)
	{
		this.Word = "Witaj";
		if (name.Length == 0)
		{
			Console.WriteLine($"{this.Word} NoName!");
		}
		else
		{
			Console.WriteLine($"{this.Word} {name}!");
		}
	}
}
