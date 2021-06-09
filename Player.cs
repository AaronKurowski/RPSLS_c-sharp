using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        // member variables
        public string name;
        public int score;
        public string chosenGesture;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        // constructor
        public Player()
        {
            score = 0;
        }

        // member methods
        public virtual void PickGesture()
        {
            while (true)
            {
                Console.WriteLine("\nThink carefully, pick a gesture! (rock, paper, scissors, lizard, spock)");
                chosenGesture = Console.ReadLine();

                if (gestures.Contains(chosenGesture.ToLower())){
                    Console.WriteLine("You chose " + chosenGesture + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid gesture.");
                    continue;
                }
            }
        }

        public virtual void SelectName()
        {
            Console.WriteLine("Welcome. Enter your name!");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

    }
}
