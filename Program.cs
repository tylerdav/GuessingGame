using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);

            Console.WriteLine("guess a number between 1 and 10");
            string userGuess = Console.ReadLine();
            int userGuessInt = int.Parse(userGuess);

            if (userGuessInt == secretNumber)
            {
                Console.WriteLine($"You Guessed it! It was {secretNumber}");
                return;
            }
            else if (userGuessInt < secretNumber)
            {
                Console.WriteLine("Nope, too low!");
            }
            else if (userGuessInt > secretNumber)
            {
                Console.WriteLine("Nope, too high!");
            }
            else
            {
                Console.WriteLine("nope that wasn't it");
            }

        }
    }
}
