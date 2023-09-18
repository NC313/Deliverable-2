using System;

namespace CoinFlipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
            Console.Write("What is your name?\n> ");
            string name = Console.ReadLine();

            Console.Write($"Welcome {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No\n> ");
            string response = Console.ReadLine();

            if (response.Trim().Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"You are a coward {name}");
            }
            else if (response.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                int score = 0;
                Random random = new Random();

                Console.WriteLine("The challenge begins!");

                for (int round = 1; round <= 5; round++)
                {
                    int randomNumber = random.Next(2); 
                    string correctAnswer = (randomNumber == 0) ? "Heads" : "Tails";
                    
                    Console.Write("Heads or Tails?\n> ");
                    string userGuess = Console.ReadLine();

                    if (userGuess.Trim().Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
                }

                Console.WriteLine($"Thank you {name}. You got a score of {score}!");
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter Yes or No.");
            }
        }
    }
}
