using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgrammingGame
{
   public class ProgramUI
    {
        List<string> CorrectGuesses = new List<string>();
        Solution guess= new Solution();
              



        public void Run()
        {
            Menu();
            RunMenu();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Let's play a game of Hangman\n" +
                "Here is how to play:\n" +
                "I will pick a word at random which will remain hidden. The objective is to find out the word by guessing which letters are in the word, and once you have enough information you can guess the word itself.\n" +
                "After each attempted guess I will let you know if that letter is contained within the word and I will keep you updated with a list of all of your correctly guessed letters.\n" +
                "If you guess incorrectly you will lose one of your lives. Be wise with your attempts because you will only have 10 lives available. Correct guesses may be repeated within the hidden word, be aware!\n");
            Console.WriteLine($"There are {guess.WordCharacters.Count} letters in the hidden word");
            Console.WriteLine("Good luck and have fun!");
            Console.WriteLine("Enter your guess:");
           
        }
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine();
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                //Evaluate Guess
                string correct;
                if (guess.WordCharacters.Contains(char.Parse(userInput)))
                {
                    correct = "Correct Letters";
                }
                else
                {
                    correct = "Everything Else";
                }
                switch (correct)
                {
                    case "Correct Letters":
                        CorrectGuess(userInput);
                        break;
                    case "Everything Else":
                        IncorrectGuess(userInput);
                        break;
                }
                Console.WriteLine("What is your next guess?");
            }

        }

        private void CorrectGuess(string correctGuess)
        {
            CorrectGuesses.Add(correctGuess);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Good Guess! Keep Going!");
            Console.WriteLine();
            Console.WriteLine($"Out of the {guess.WordCharacters.Count} letters in the hidden word, you have guessed {CorrectGuesses.Count} correctly. These are the correct letters you have guess so far:");
            Console.WriteLine();
            foreach (string item in CorrectGuesses)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"You have {guess.Guesses} lives left");
            Console.WriteLine();
            if (CorrectGuesses.Count > 2)
            {
                Console.WriteLine("Do you want to guess the word? (y/n)");
                Console.WriteLine();
                string guessAWord = Console.ReadLine().ToLower();
                if (guessAWord == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("What word would you like to guess?");
                    string guessWord = Console.ReadLine();
                    if (guess.Word == guessWord)
                    {
                        Console.WriteLine("Well done! You win!!! Play again if you feel up to the challenge.");
                        Console.ReadLine();
                        CorrectGuesses.Clear();
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Nope, that wasn't correct.");
                        Console.WriteLine($"You have {(guess.Guesses -= 1)} lives left!");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Keep guessing...");
                }
            }


        }

        private void IncorrectGuess(string incorrectGuess)
        {
            Console.WriteLine();
            Console.WriteLine($"Out of the {guess.WordCharacters.Count} letters in the hidden word, you have guessed {CorrectGuesses.Count} correctly. These are the correct letters you have guess so far:");
            Console.WriteLine();
            foreach (string item in CorrectGuesses)
            {
                Console.WriteLine($"{ item}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Wrong! This word does not contain '{incorrectGuess.ToUpper()}' Try Again!");
            int lostalife = guess.Guesses -= 1;
            Console.WriteLine();
            Console.WriteLine($"You have {lostalife} lives left!");
            if (lostalife == 0)
            {
                Console.WriteLine("You lose! Try again!");
                Console.WriteLine($"The correct word was {guess.Word}");
                Console.ReadLine();
                guess.Guesses = 10;
                Menu();
            }

        }


    }
}
