class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int numberToGuess = rand.Next(1, 101);
        int remainingGuesses = 7;

        while (true)
        {
            Console.Write("Enter a guess (1-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                if (guess == numberToGuess)
                {
                    Console.WriteLine("Congratulations! You guessed the number in " + (7 - remainingGuesses) + " tries.");
                    break;
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low. " + remainingGuesses + " remaining.");
                }
                else
                {
                    Console.WriteLine("Too high. " + remainingGuesses + " remaining.");
                }
                remainingGuesses--;
                if (remainingGuesses == 0)
                {
                    Console.WriteLine("You lost! The number was " + numberToGuess);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
