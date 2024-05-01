using System;
using static System.Console;
using static System.Random;

class Program
{
    static void Main(string[] args)
    {
        /*This is a game to guess a random integer between 1 and 100.
        Once the correct guess has been made, the user is told their total number of guesses.*/
        
        // Introductory Message
        WriteLine("Welcome to the guessing game!\nGuess an integer between 1 and 100");

        // Menu Do/While
        string playAgain; // Exit condition
        do {
            Random random = new Random();

            int magicNum = random.Next(1, 101);

            int guess;
            int count = 0;
            do {
                Write("What is your guess?: ");
                string guessStr = ReadLine();
                guess = int.Parse(guessStr);

                if (guess > magicNum)
                {
                    WriteLine("Lower");
                }
                else if (guess < magicNum)
                {
                    WriteLine("Higher");
                }

                count += 1;
            } while (guess != magicNum);

            WriteLine("You guessed it!");
            WriteLine($"{count} guesses.\n");

            WriteLine("Would you like to play again?(Y/N)");
            playAgain = ReadLine();
            playAgain = playAgain.ToUpper();

        } while (playAgain == "Y");

    }
}