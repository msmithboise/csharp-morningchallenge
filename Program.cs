using System;
using csharp_morningchallenge.Models;

namespace csharp_morningchallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Hey Welcome to the number game lets play a game!");

            Game game = new Game();
            bool playing = true;
            while (playing)
            {

                System.Console.WriteLine($"Make as guess (so far you have guessed {game.Guesses} times):");
                string guessString = Console.ReadLine();
                int guess;
                if (!Int32.TryParse(guessString, out guess))
                {

                    System.Console.WriteLine("not a good Number, try again.");
                    // continue;
                }
                string result = game.Guess(guess);
                System.Console.WriteLine(result);
                if (game.Won)
                {
                    System.Console.WriteLine("great job!  Want to play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again != null && again.ToLower()[0] == 'n')
                    {
                        playing = false;
                    }
                    else
                    {
                        game = new Game();
                    }
                }

            }
            System.Console.WriteLine("Goodbye!");
        }
    }
}

