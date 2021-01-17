using System;
using System.Collections.Generic;
using System.Text;

namespace BattleArenaDream_CSharp
{
    
    class Dice // roll the dice to play the game
    {
        // variables

        // "readonly indicates that an instance member doesn't modify the state of the structure."
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
        private readonly Random random = new Random();
        private int diceRoll = 0; // should be rolled before referenced
        
        public Dice() { } // for good measure

        // roll the dice
        public void RollDice()
        {
            diceRoll = random.Next(1, 6);
        }

       // getters and setters
       // TODO See if there's a way to generate getts and setters like in Eclipse
       public int DiceRoll { get; set; } // there's a shortcut for C# - this is the shortest one

    }
}
