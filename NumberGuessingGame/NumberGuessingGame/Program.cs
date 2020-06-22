using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create random number
            var numberToGuess = new Random().Next(101);
            var playGame = false;

            IntroduceGame();

            // Checks to see if players guess is correct and loops until it is correct
            while (playGame != true)
            {
                var playerGuess = PlayerGuess();
                playGame = CheckUsersGuess(numberToGuess, playerGuess);
            }

        }
        public static void IntroduceGame()
        {
            // Say hi and game introduction message
            Console.WriteLine("Welcome contestant!");
            Console.WriteLine("I am thinking of a number between 1 and 100. Can you guess what it is?");
        }

        /// <summary>
        /// Ask player to make a guess and store result,
        /// validates input to make sure it is an integar.
        /// </summary>
        /// <returns>The players guess as an integar</returns>
        public static int PlayerGuess()
        {
            // set an initial variable to a value higher than the allowed guess
            var validatePlayersGuess = 101;
            // Tell player to take a guess
            Console.WriteLine("Take a guess:");

            while (validatePlayersGuess > 100)
            {
                // Take players guess input as a string
                var playersGuess = Console.ReadLine();

                // Try to convert string to an int
                var guessIsAnInt = int.TryParse(playersGuess, out var guessValid);
                // If the input was successfully coverted to an int, set the
                // initial variable to the guess to break out of the loop
                if (guessIsAnInt && guessValid <= 100)
                    return validatePlayersGuess = guessValid;
                // Otherwise remind player of what is an acceptable guess
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }
            }

            // Return the guess as an int 
            return validatePlayersGuess;

        }

        /// <summary>
        /// Takes the result of the users guess and checkes to see
        /// if it is larger or smaller than the random number.
        /// </summary>
        /// <param name="number">The random number generated</param>
        /// <param name="guess">The users guess</param>
        /// <returns>a true boolean if the guess is correct and false if not.</returns>
        public static bool CheckUsersGuess(int number, int guess)
        {
            if (guess > number)
            {
                Console.WriteLine("Too high! Try again");
                return false;
            }

            else if (guess < number)
            {
                Console.WriteLine("Too low! Try again");
                return false;
            }

            else
            {
                Console.WriteLine("That is correct! Well done!");
                return true;
            }
        }




    }
}
