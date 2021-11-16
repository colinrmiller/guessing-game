using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumberGuessed = false;
            int guessCount = 0;
            int secretNumber = new Random().Next(1, 100);
            Object objectTest = new Object();
            int numberOfGuesses = 0;
            bool cheatActivated = false;

            Console.WriteLine(@"
            Select Difficulty:
                1) EASY
                2) MEDIUM
                3) HARD
                4) CHEATER
            > ");
            int difficultyChoice = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("reading choice");
                switch (difficultyChoice)
                {
                    case 1:
                        numberOfGuesses = 8;
                        goto RunGame;
                    case 2:
                        numberOfGuesses = 6;
                        goto RunGame;
                    case 3:
                        numberOfGuesses = 4;
                        goto RunGame;
                    case 4:
                        cheatActivated = true;
                        numberOfGuesses = 2;
                        goto RunGame;

                }

            }
        RunGame:
            while (isNumberGuessed == false && guessCount < numberOfGuesses)
            {
                guessCount += 1;
                if (cheatActivated) guessCount = 0;

                Console.WriteLine("Guess the secret number:");

                if (cheatActivated) Console.Write($"Your guess (cheater) > ");
                else Console.Write($"Your guess ({numberOfGuesses - guessCount + 1} guesses left)> ");

                int userGuess = int.Parse(Console.ReadLine());

                if (secretNumber == userGuess)
                {
                    isNumberGuessed = true;
                    Console.WriteLine("You guessed the number!");
                }
                else
                {
                    if (secretNumber > userGuess)
                    {
                        Console.WriteLine("Incorrect. Guess too low.");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Guess too high.");
                    }
                }
            }

        }
    }
}
