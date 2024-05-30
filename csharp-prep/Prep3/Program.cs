using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to guess a number and If they guessed the number, tell them they guessed it. If they did not guess the user specified the number...
      
        
        // Generate a random number
        Random randomGenerator = new Random();

        // int secretNumber = random.Next(1, 101);
        int secretNumber = randomGenerator.Next(1, 101);
        int guess = 0;

        Console.WriteLine("Guess a number between 1 and 100");
        
        // Use a while loop
        int guessCount = 0;
        while (guess != secretNumber)
        {
            // provide count of guesses
            guessCount += 1; 
            
            // Ask the user to guess a number
            Console.Write("What is your guess number? ");

            // store the user's guess in a variable called guess
            guess = int.Parse(Console.ReadLine());

            if (secretNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (secretNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }

        }                    
    }
}
