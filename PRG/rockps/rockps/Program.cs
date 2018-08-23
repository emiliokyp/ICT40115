using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockps
{
    class Program
    {
        static void Main(string[] args)
        {
            int player_1 = -1;
            int player_1_score = 0;
            int player_2 = -1;
            int player_2_score = 0;
            int rounds = 0;

            while (rounds < 3)
            {
                Console.WriteLine("P1: rock, paper or scissors");
                string inputP1 = Console.ReadLine();
                player_1 = int.Parse(inputP1);

                Random rand = new Random();
                player_2 = rand.Next(3);
                Console.WriteLine("AI Picked: {0}", player_2);

                // Rock validation
                if (player_1 == 0 && player_2 != 0)
                {
                    player_1_score++;
                    Console.WriteLine("Player 1 wins the round 0");
                } else if (player_2 == 0 && player_1 != 0)
                {
                    player_2_score++;
                    Console.WriteLine("Player 2 wins the round");
                } else if (player_1 == 0 && player_2 == 0)
                {
                    Console.WriteLine("The round was a draw!");
                }


                if (player_1 == 1 && player_2 == 1)
                {
                    Console.WriteLine("The round was a draw!");
                }

                // Scissors validation
                if (player_1 == 2 && player_2 != 0 && player_2 != 2)
                {
                    player_1_score++;
                    Console.WriteLine("Player2 1 won the round 2");
                } else if (player_2 == 2 && player_1 != 0 && player_1 != 2)
                {
                    player_2_score++;
                    Console.WriteLine("Player 2 won the round");
                } else if (player_1 == 2 && player_2 == 2)
                {
                    Console.WriteLine("The round was a draw!");
                }


                
                // Winner validation
                if (rounds == 2)
                {
                    if (player_1_score > player_2_score)
                        Console.WriteLine("Player 1 Wins The Game!");
                    else if (player_1_score == player_2_score)
                        Console.WriteLine("The game was a draw!");
                    else
                        Console.WriteLine("Player 2 Wins The Game!");


                }

                rounds++;


            } 
        }
    }
}
