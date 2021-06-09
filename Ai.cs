using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Ai : Player
    {
        Random random = new Random();
        public List<string> npcNames = new List<string>() { "Jarvis", "Hal", "Stiffler" };
        public Ai()      
        {
            score = 0;
        }

        public override void PickGesture()
        {
            int randomIndex = random.Next(0, 5);
            chosenGesture = gestures[randomIndex];
        }

        public override void SelectName()
        {
            // randomly selects name
            int num = random.Next(0, 3);
            name = npcNames[num];
            Console.WriteLine("NPC is " + name);
        }
    }
}
