using System;
using System.Collections.Generic;
using System.Text;

namespace BattleArenaDream_CSharp
{
    
    class Dice // roll the dice to play the game
    {
        // variables
        private Random random = new Random();
        private int diceRoll = 0; // should be rolled before referenced

        // roll the dice
        public void rollDice()
        {
            diceRoll = random.Next(1, 6);
        }

       // getters and setters
       // TODO See if there's a way to generate getts and setters like in Eclipse
       public int DiceRoll // there's a shortcut for C#
        {
            get { return diceRoll; }
            set { diceRoll = value; }
        }

    }
}
