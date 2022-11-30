using System;

namespace Backend_week3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("test");

			Console.WriteLine("   /|");
			Console.WriteLine("  / |");
			Console.WriteLine(" /  |");
			Console.WriteLine("/_ _|");

			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("random text");
			Console.ResetColor();
		}
	}
}
