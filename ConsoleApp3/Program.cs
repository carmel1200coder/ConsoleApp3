using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman { }
    public class Hangman
{
    public static void Main()
    {
        Console.WriteLine("Welcome to hangman!");

        string word = string.Empty;
        string guess = string.Empty;
        int guessesLeft = 10; // "10"

        Console.WriteLine("Please enter your word: ");

        //get the hangman word from the user
        word = Console.ReadLine();

        Console.WriteLine("Your word is " + word);

        while (guessesLeft > 0)
        {
            Console.WriteLine("You have " + guessesLeft + " guesses left");

            Console.WriteLine("Please enter your guess as a single letter:");
            guess = Console.ReadLine();

            Console.WriteLine("Your guess is " + guess);

            //get the result of their first guess
            bool correctGuess = word.Contains(guess);

            //tell them the result of their firsst guess
            if (correctGuess == false)
            {
                Console.WriteLine("You guessed wrong");
                //if they guessed wrong, then I need to decrease the number of guesses they have left
                guessesLeft--;
            }
            else
            {
                Console.WriteLine("You guessed right");
                if (word.Equals(guess))
                {
                    Console.WriteLine("You win!");
                    return;
                }
            }

        }

        //if they guessed right, then I need to store their guess, I think
        //Console.WriteLine("You have " + guessesLeft + " guesses left");

    }
}



