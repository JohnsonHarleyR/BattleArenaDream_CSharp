using System;

namespace BattleArenaDream_CSharp
{
    class Program
    {
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

            }

		}
	}
}
