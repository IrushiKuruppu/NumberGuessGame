using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNumber = random.Next(1, 11);
            Console.WriteLine("Welcome to number guessing game!");
            Console.WriteLine("Number between 1 and 10 will be generated");
            Console.WriteLine("If you guess the correct number, you will win!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess!");
                int guess = int.Parse(Console.ReadLine());

                if(guess > randomNumber)
                {
                    Console.WriteLine("The number you entered is too high!");
                }
                else if(guess < randomNumber){
                    Console.WriteLine("The number you entered is too low!");
                }
                else
                {
                    Console.WriteLine("The number you entered is correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congradulations you won the game !");

        }
    }
}