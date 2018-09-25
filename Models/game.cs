using System;

namespace csharp_morningchallenge.Models
{
    public class Game
    {
        private int _secretNumber;  //_ means it shouldn't be changed, and it's private

        public int Guesses { get; set; }

        public bool Won { get; set; }

        public string Guess(int guess)
        {
            Guesses++;

            if (guess > _secretNumber)
            {

                return "too high";
            }
            else if (guess < _secretNumber)
            {
                return "too low";
            }
            Won = true;
            return "You got it!";

        }
        public Game()
        {
            Random rnd = new Random();
            _secretNumber = rnd.Next(1, 101);
            Won = false;
            Guesses = 0;
        }
    }


}


