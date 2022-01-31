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

        int PlayerPosition = 0, count = 0, Winning_Position = 10;

        public void Play()
        {
            Console.WriteLine("The Game is Start");
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            while (this.PlayerPosition < Winning_Position)

            {
                
                int Roll = random.Next(0, 3);
                switch (Roll)
                {
                    case NoPlay:
                        Console.WriteLine("Player is not rolled the dice");
                        break;
                    case Ladder:
                        if (this.PlayerPosition + DiceRoll <= 100)
                        {


                            PlayerPosition += DiceRoll;
                        }
                        break;
                    case Snake:
                        if (this.PlayerPosition - DiceRoll >= 0)
                        {
                            this.PlayerPosition = PlayerPosition - DiceRoll;
                        }
                        else
                        {
                            PlayerPosition = 0;

                        }

                        break;
                    default:
                        break;

                     
                }
                count++;

                Console.WriteLine("Player position" + this.PlayerPosition);

                Console.WriteLine("Number of time Dice Rolled"+count);
                
            }
            
        }
    }
}