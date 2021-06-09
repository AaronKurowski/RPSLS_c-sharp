﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables
        int numberOfRounds;

        // constructor
        public Game()
        {
            DefineContestants();
        }

        // member methods
        public void RunGame()
        {
            // opening statement
            // define contestants
            // battle
            // declare winner

            OpeningStatements();


            Console.ReadLine();
        }

        public void OpeningStatements()
        {
            //Console.WriteLine("\nWelcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors, Lizard, Spock!" +
              "\n\nHere are the rules:" +
              "\n\nRock crushes Scissors" +
              "\nScissors cuts Paper" +
              "\nPaper covers Rock" +
              "\nRock crushes Lizard" +
              "\nLizard poisons Spock" +
              "\nSpock smashes Scissors" +
              "\nScissors decapitates Lizard" +
              "\nLizard eats paper" +
              "\nPaper disproves Spock" +
              "\nSpock vaporizes Rock");
        }

        public void DefineContestants()
        {
            Console.WriteLine("Press 1 to play against a Human or type anything else to play against an AI");
            string opponent = Console.ReadLine();

            if(opponent == "1")
            {
                Player playerOne = new Player();
                Player playerTwo = new Player();
            }
            else
            {
                Player playerOne = new Player();
                Ai npc = new Ai();
            }
        }


    }
}
