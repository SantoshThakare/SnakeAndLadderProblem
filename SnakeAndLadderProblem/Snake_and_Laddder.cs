using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Snake_and_Laddder
    {
        const int NoPlay = 0, Ladder = 1, Snake = 2;

        int PlayerPosition = 0;
        public void Play()
        

        {
            Console.WriteLine("The Game Start");
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("The dice outcome is: " + DiceRoll);
            
                int Roll = random.Next(0, 3);
                switch (Roll)
                {
                    case NoPlay:

                        break;
                    case Ladder: 
                        PlayerPosition += DiceRoll;
                        break;
                    case Snake:
                        PlayerPosition -= DiceRoll;
                        break;
                }
                Console.WriteLine("Dice is: " + Roll + "\n \n Player position is: " + PlayerPosition);


            
        }
    }
}