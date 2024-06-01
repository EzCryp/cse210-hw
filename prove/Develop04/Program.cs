using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        int choice;
        string input;
        while (loop)
        {
            // Display 4 menu options, then prompt the user to select a choice
            Console.WriteLine("\nMenu Options:\n");
            Console.WriteLine("  1. Start Breathing activity");
            Console.WriteLine("  2. Start Reflecting activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Quit\n");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            // If the user enters a valid integer, execute the corresponding activity
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    // Start the Breathing activity
                    case 1:
                        Console.Clear();
                        BreathingActivity breatheActivity = new BreathingActivity();
                        breatheActivity.Start();
                        break;
                    // Start the Reflecting activity
                    case 2:
                        Console.Clear();
                        ReflectingActivity reflectActivity = new ReflectingActivity();
                        reflectActivity.Start();
                        break;
                    // Start the Listing activity
                    case 3:
                        Console.Clear();
                        ListingActivity listActivity = new ListingActivity();
                        listActivity.Start();
                        break;
                    // Quit the program
                    case 4:
                        Console.Clear();
                        loop = false;
                        break;
                    // If the user enters an invalid choice, display an error message
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }

    // Get the desired duration for the activity
    // Returns: the duration in seconds
    static int GetDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter the desired duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer value.");
        }
    }
}