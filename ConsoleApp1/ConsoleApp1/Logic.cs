using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Logic
    {
        public void Play()
        {
            Random random = new Random();

            Console.WriteLine("----------Welcome to Rock, Paper, Scissors!----------\n");

            Console.Write("Enter number of rounds: ");
            int rounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int playerWins = 0;
            int computerWins = 0;

            int winCondition = (rounds / 2) + 1;

            while (rounds > 0 && playerWins<winCondition && computerWins<winCondition)
            {
                Console.Write("Enter your choice: ");
                int player = Convert.ToInt32(Console.ReadLine());

                while (player < 1 || player > 3)
                {
                    Console.Write("Invalid input. enter number between 1-3: ");
                    player = Convert.ToInt32(Console.ReadLine());
                }

                int computer = random.Next(1, 4);

                Console.WriteLine("Computer chose: " + computer);

                if (player == computer)
                {
                    Console.WriteLine("It's a tie!\n");
                }
                else if ((player == 1 && computer == 3) || (player == 2 && computer == 1) || (player == 3 && computer == 2))
                {
                    Console.WriteLine("You win this round!\n");
                    playerWins++;
                    rounds--;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!\n");
                    computerWins++;
                    rounds--;
                }


                if (playerWins >= winCondition)
                {
                    Console.WriteLine("\ncongrats!!!!!");
                    Console.WriteLine("You win the game!");
                    break;
                }

                if (computerWins >= winCondition)
                {
                    Console.WriteLine("humans are weak!!!!!");
                    Console.WriteLine("Computer wins the game!");
                    break;
                }
            }

            
            Console.Write("\ndo you wanna play again (y/n): ");
            char response = (char )Console.Read();
            Console.ReadLine(); // clears leftover input
            response = char.ToLower(response);
            if (response == 'y')
            {
                Play();
            }
            else if (response == 'n')
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
            else
            {
                Console.WriteLine("invalid input...thank you for playing!!!!");
            }



        }
    }
}
