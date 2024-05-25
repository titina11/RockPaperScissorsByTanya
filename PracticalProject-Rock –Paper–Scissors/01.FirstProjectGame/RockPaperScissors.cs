﻿namespace _01.FirstProjectGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Random random = new Random();
            int computerRandonNumber = random.Next(1, 4);

            string computerMove = "";

            switch (computerRandonNumber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
            }

            Console.WriteLine($"The computer chose {computerMove}.");
            if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == scissors && computerMove == rock) || (playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors))
            {
                Console.WriteLine("You lose.");
            } 
            else
            {
                Console.WriteLine("This game was a draw.");
            }
                       
        }
    }
}
