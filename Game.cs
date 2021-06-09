using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables

        // constructor

        // member methods
        public void RunGame()
        {
            Player playerOne = new Player();
            Ai npc = new Ai();
            
            playerOne.SelectName();
            playerOne.PickGesture();
            npc.SelectName();
            npc.PickGesture();

            Console.ReadLine();
        }
    }
}
