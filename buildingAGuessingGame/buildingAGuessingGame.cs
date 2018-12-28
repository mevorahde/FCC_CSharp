using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingAGuessingGame
{
    class buildingAGuessingGame
    {
        static void Main(string[] args)
        {
            //Building a guessing game where the user has three attempts to guess the secret word.
            
            //variable for the secret word
            string secretWord  = "giraffe";
            //variable for the users guess
            string guess = "";
            //variable for the amount of time the user has guessed
            int guessCount = 0;
            //variable for the limit that the user has to guess the secret word.
            int guessLimit = 3;
            //variable if the user is out of guesses or not
            bool outOfGuesses = false;

            //if the user is not out of guesses and hasn't gussed the secret word, as the user to guess the secret word. Add 1 to the guess count for each guess.
            //if the variable outOfGuesses is true, the game is over.
            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Please enter a guess on what the secret word is: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
          

            } while (guess != secretWord && ! outOfGuesses);

            //if out of guesses is true, let the user know they have lost.
            if (outOfGuesses)
            {
                Console.WriteLine("You lose! You did not guess the secret word.");
            }
            //if the user has guessed the secret word, let the user know they have won and let them know how many attempts it took.
            else
            {
                Console.WriteLine("You win! You guessed the secret word!");
                if (guessCount == 1)
                {
                    Console.WriteLine("It took you " + guessCount + " try!");
                }
                else
                {
                    Console.WriteLine("It took you " + guessCount + " tries!");
                }
                
            }
            

            Console.ReadLine();
        }
    }
}
