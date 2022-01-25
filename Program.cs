using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //guess secret number
            //prompt for user's guess
            //take input and save as variable
            //display user's guess
            Console.WriteLine("Please guess the secret number.");
            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            // Console.WriteLine($"You guessed {userInput}.");
            //variable secret number 42
            
            //Compare secret number vs number they guessed
            //success or failure message
            int secretNumber = 42;
            if (parsedUserInput == 42)
            {
                Console.WriteLine($"The answer to the universe is {secretNumber}");
            }
            else
            {
                Console.WriteLine("WRONG-O!");
            }
        }
        
    }
}