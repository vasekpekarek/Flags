/*
 * Created by SharpDevelop.
 * User: Peki
 * Date: 21.10.2019
 * Time: 19:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace vlajkyPek
{
	class Program
	{
		public static int vyska = 15;
		public static int sirka = 40;
		public static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\t\t ====> Vlajky <==== \t\t");
			Console.ResetColor();
			Console.WriteLine("Zvol si vlajku, kterou budeš chtít zobrazit.");
			Console.WriteLine("Volba 1 - CZ\nVolba 2 - DE\nVolba 3 - US");

			string konec = "";
			while (konec != "q") 
			{
				try
				{
					Console.Write("Tvoje volba: ");
					int volba = Int32.Parse(Console.ReadLine());
					switch (volba) 
					{
						case 1 :
							FlagCZ();
							break;
						case 2 :
							FlagDE();	
							break;
						case 3 :
							FlagUS();
							break;
						default:
							Console.WriteLine("Byla zadána neplatná volba.");
							break;	
					}
				}
				catch (Exception ex)
				{
				Console.WriteLine("Špatná volba.");
				}
			Console.Write("Pro ukončení programu stiskni 'q' nebo pokračuj klávesou ENTER.");
			konec = Console.ReadLine();	
			}
		}

		public static void FlagCZ()
		{
			for (int i = 1; i <=vyska/2; i++) 
			{
				for (int j = 1; j <= i; j++) 
				{
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.Write(" ");
				}
				for (int k = 1; k <=sirka-i; k++) 
				{
					Console.BackgroundColor = ConsoleColor.White;
					Console.Write(" ");
				}
				
				Console.WriteLine();
			}
			for (int i =vyska/2; i >= 1; i--) 
			{
				for (int j = 1; j <= i; j++) 
				{
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.Write(" ");
				}
				for (int k = 0; k < sirka-i; k++) 
				{
					Console.BackgroundColor = ConsoleColor.Red;
					Console.Write(" ");
					Console.ResetColor();
				}
				Console.WriteLine();
			}
		}
		public static void FlagDE()
		{
			for (int a = 0; a < sirka; a++) 
			{
				Console.Write("_");
			}
			for (int i = 0; i < vyska/3; i++) 
			{
				for (int j = 0; j < sirka; j++) 
				{
					Console.Write(" ");
				}
				Console.WriteLine("|");
			}
			for (int i = 0; i < vyska/3; i++) 
			{
				for (int j = 0; j < sirka; j++) 
				{
					Console.BackgroundColor = ConsoleColor.DarkRed;
					Console.Write(" ");
				}
				Console.WriteLine("");
			}
			for (int i = 0; i < vyska/3; i++) 
			{
				for (int j = 0; j < sirka; j++) 
				{
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.Write(" ");
					Console.ResetColor();
				}
				Console.WriteLine("");
			}
		}
		public static void FlagUS()
		{
			for (int i = 0; i < vyska; i++) 
			{
				for (int j = 0; j < sirka; j++) 
				{
					if (i <= vyska/2 && j < sirka/2) 
					{
						Console.BackgroundColor = ConsoleColor.DarkBlue;
						Console.Write("*");				
					}
					else
					{
					Console.BackgroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Red;
					Console.Write("▄");
					Console.ResetColor();
					}
				}
				Console.WriteLine();
			}
		}
	}
	
}