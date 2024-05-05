using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to guess a number and If they guessed the number, tell them they guessed it. If they did not guess the user specified the number...
        // Console.Write("What is the guess number? ");
        // int secretNumber = int.Parse(Console.ReadLine());
        
        // Generate a random number
        Random randomGenerator = new Random();

        // int secretNumber = random.Next(1, 101);
        int secretNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        // Use a while loop
        while (guess != secretNumber)
        {
            Console.Write("What is your guess number? ");
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
            }

        }                    
    }
}
