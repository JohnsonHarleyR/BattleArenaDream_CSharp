using System;

namespace BattleArenaDream_CSharp
{
    class Program
    {
		// I re-typed most of the code that is the same as in the Java program, only a few things were 
		// copy and paste like comments and a couple arrays. I did this for the sake of memorization
		static void Main(string[] args)
        {
			// notes for reference
			// Console.Read();
			// Console.WriteLine($"My age is {myAge}. Your age is {yourAge}.");
			// \r means a carriage return - moves cursor to the very far left

			// variables
			string[] diceFronts = new string[]
			{// To get the circles lined perfectly, they would be too large.
				" _________ \n"				// This is good for now. (Java didn't want to accept an overline char.)
			  + "|         |\n"
			  + "|         |\n"
			  + "|    O    |\n"
			  + "|         |\n"
			  + "|_________|",
			  			" _________ \n"
					  + "|         |\n"
					  + "| O       |\n"
					  + "|         |\n"
					  + "|       O |\n"
					  + "|_________|",
								" _________ \n"
							  + "|         |\n"
							  + "| O       |\n"
							  + "|    O    |\n"
							  + "|       O |\n"
							  + "|_________|",
							  			" _________ \n"
									  + "|         |\n"
									  + "| O     O |\n"
									  + "|         |\n"
									  + "| O     O |\n"
									  + "|_________|",
									  			" _________ \n"
											  + "|         |\n"
											  + "| O     O |\n"
											  + "|    O    |\n"
											  + "| O     O |\n"
											  + "|_________|",
											  			" _________ \n"
													  + "|         |\n"
													  + "| O     O |\n"
													  + "| O     O |\n"
													  + "| O     O |\n"
													  + "|_________|",};
			string[] endings = new string[]
			{"...Will this ever end?", "Is fighting your purpose in life?",
				"An existential crisis sets in as you wonder why this won't end.",
				"Why does he bring you back to die again?\nYou're getting too deep so you shake yourself out of it.",
				"If this is a dream, it's more like a nightmare.", "Does he expect you to do this all on your own?",
				"If he has so much power, why are you the one fighting?",
				"You ask, \"Hey, could I get some help?\" The grim reaper shakes his head.",
				"How many enemies must you defeat? How many lives must you live?",
				"You wonder if you'll get a prize at some point.",
				"You tell him that you're more of a philosopher than a fighter, but the grim reaper shrugs.",
				"\"What happens if I refuse to kill more?\", you ask."
				+ "\n\"You die,\" he replies. \"Oh...\" You let out a sigh."};

			// Intro title
			Console.WriteLine(" __       ___ ___       ___          __   ___           \r\n" +
					"|__)  /\\   |   |  |    |__      /\\  |__) |__  |\\ |  /\\  \r\n" +
					"|__) /~~\\  |   |  |___ |___    /~~\\ |  \\ |___ | \\| /~~\\ \n");
			Console.WriteLine("You open your eyes to see a sword in one hand and a shield in the other. You hear cheering.");
			Console.WriteLine("How strange, you look around to see you are standing in an arena with no crowd.");
			Console.WriteLine("\nIs this real life or a dream?");

			// The dream runs an infinite loop so the user must close the app in order to exit.
			while (true)
            {
				Dice dice = new Dice();
				
            }

		}

		// Methods for the game

		// Show player's stats
		public static void showStats(Player player, Enemy enemy, int turns)
        {
			if (turns == 10) // only on first turn
            {
				Console.WriteLine("\n*Your Stats*");
            }
			else
            {
				Console.WriteLine("\n*New Stats*");
			}
			Console.WriteLine($"Stamina: {player.Stamina}"); // new trick in C# but not Java - try to remember this
			Console.WriteLine($"Panic Level: {player.Panic}");
			Console.WriteLine($"Enemy HP: {enemy.Hp}");
		}

		// Get the outcome of a dice roll
		public static void getOutcome(Player player, Enemy enemy, Dice dice)
        {
			// determine the outcome by what the player rolled
			int diceRoll = dice.DiceRoll;

			switch (diceRoll)
            {
				case 1:
					Console.WriteLine("The enemy smirks as he taunts you. He seeks to intimidate."
							+ "\nIt works. Your panic increases by 2.");
					player.Panic = player.Panic + 2;
					break;
				case 2:
					Console.WriteLine("The enemy attacks! You dodge, but he strikes anyway!\nYour stamina " +
							"decreases by 1.");
					player.Stamina = player.Stamina - 1;
					break;
				case 3:
					Console.WriteLine("The enemy strikes, but you block the attack!\nNothing else happens.");
					break;
				case 4:
					Console.WriteLine("You let out a beastly growl. The enemy backs away!\nYour stamina increases by 1.");
					player.Stamina = player.Stamina + 1;
					break;
				case 5:
					Console.WriteLine("You swing your sword. The enemy dodges, but you strike anyway!" +
							"\nYour panic reduces by 1. The enemy loses 3 hit points.");
					player.Panic = player.Panic - 1;
					enemy.Hp = enemy.Hp - 3;
					break;
				case 6:
					Console.WriteLine("*THWACK* You swing fast to strike a critical blow with your sword!" +
							"\nYour panic reduces by 3. Your stamina increases by 2. The enemy loses 5 hit points.");
					player.Panic = player.Panic - 3;
					player.Stamina = player.Stamina + 2;
					enemy.Hp = enemy.Hp - 5;
					break;
				default:
					Console.WriteLine("ERROR - not a number 1 through 6");
					break;
			}
        }

	}
}
