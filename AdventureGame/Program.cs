using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
	class Program
	{
		static void Main(string[] args)
		{
			GameTitle();

		}

		public static void GameTitle()
		{
			Console.WriteLine("Adventure Game");
			Console.WriteLine("Press Enter to begin.");
			Console.ReadLine();
			Console.Clear();
			First();
		}

		public static void First()
		{
			string choice;
			Console.WriteLine("You wake up and your teacher, Mr. Storm is angry!");
			Console.WriteLine("What do you do?");
			Console.WriteLine("1.) Punch him");
			Console.WriteLine("2.) Cry");
			Console.WriteLine("3.) Scream out of fear");
			Console.WriteLine("Choice: ");
			choice = Console.ReadLine().ToLower();
			Console.Clear();

			switch (choice)
			{
				case "1":
				case "punch him":
				case "punch":
					{
						Console.WriteLine(Character.PunchCase());
						Console.WriteLine("All the other studends cheer!");
						Console.WriteLine("Mrs. Storm hears the commotion and investigates.");
						Console.WriteLine("She zaps you with her laser eyes.");
						Console.WriteLine("Press Enter to continue");
						Console.ReadLine();
						GameOver();
						break;

					}
				case "2":
				case "cry":
					{
						Console.WriteLine(Character.CryCase());
						Console.WriteLine("\"You want to cry? Do it out in the hall!\" he screamed at the top of his lungs.");
						Console.WriteLine("Press 'enter' to continue.");
						Console.ReadLine();
						Second();
						break;

					}
				case "3":
				case "pee":
				case "pee a little":
					{
						Console.WriteLine(Character.PeeCase());
						Console.WriteLine("\"Did you just...? Get out of here!\" he screams at the top of his lungs.");
						Console.WriteLine("Press 'enter' to continue.");
						Console.ReadLine();
						Second();
						break;

					}
				default:
					{
						Console.WriteLine("I don't understand that command...");
						Console.WriteLine("Press Enter to try again.");
						Console.ReadLine();
						First();
						break;
					}
			}
		}

		public static void Second()
		{
			Random rnd = new Random();
			string[] secOptions = { "In the hallway, you see that the cops are searching lockers.",
			"In the hallway you see your stalker walking toward you.",
			"In the hallway the fire alarm goes off."};
			int randomNumber = rnd.Next(0, 3);
			string secText = secOptions[randomNumber];
			string secChoice;
			Console.WriteLine(secText);
			Console.WriteLine("Do you try to hide in the bathroom? Yes or No");
			Console.Write("Choice: ");
			secChoice = Console.ReadLine().ToLower();

			if (secChoice == "yes" || secChoice == "y")
			{
				Third();
			}
			else if (secChoice == "no" || secChoice == "n")
			{
				Console.WriteLine("A meteor slams in to the school at that exact moment, killing everyone.");
				Console.WriteLine("Press 'Enter' to continue.");
				Console.ReadLine();
				GameOver();
			}
			else
			{
				Console.WriteLine("I don't understand that command...");
				Console.WriteLine("Press Enter to try again.");
				Console.ReadLine();
				Second();
			}

		}

		public static void Third()
		{
			int age;
			Console.WriteLine("You burst into the bathroom and all of your friends and family are there.");
			Console.WriteLine("They yell \"Surprise!\" and you remember it's your birthday.");
			Console.WriteLine("How old are you?");
			Console.Write("Age: ");
			int.TryParse(Console.ReadLine(), out age);

			while (age < 100)
			{
				Console.WriteLine("Seriously? You look older than that.");
				Console.WriteLine("How old are you really?");
				Console.Write("Age: ");
				int.TryParse(Console.ReadLine(), out age);
			}
			Console.WriteLine("Wow, you're old!");
			YouWin();
		}

		public static void GameOver()
		{
			Console.WriteLine("Welp, you died. Better luck next time.");
			Console.WriteLine("Press 'Enter' to go back to the title screen.");
			Console.ReadLine();
			Console.Clear();
			GameTitle();
		}

		public static void YouWin()
		{
			Console.WriteLine("Congratulations! You won!");
			Console.WriteLine("There is only one ending!");
			Console.WriteLine("Press 'Enter' to go back to the title screen.");
			Console.ReadLine();
			Console.Clear();
			GameTitle();
		}


	}
}
