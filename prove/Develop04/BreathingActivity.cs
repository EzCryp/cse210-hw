using System;

class BreathingActivity : Activity
{
    public override void Start()
    {
        base.Start();
        // Display a welcome message and instructions for the Breathing Activity
        Console.WriteLine("Welcome to the  Breathing Activity.\n");
        Console.Write("This section of the program will help you relax by walking you through a breathing exercise.");
        Console.WriteLine("\nThis exercise will help you focus on your breathing and clear your mind.\n");
        
        // Prompt the user to enter the duration of the breathing exercise
        int duration = GetDuration();
        int total = duration;
        Console.Clear();
        // Loop through the breathing exercise until the duration is complete
        while (duration > 0)
        {
            Console.Write("Breathe in... ");
            CountDown(4);
            Thread.Sleep(1000);

            Console.Write("Now, Hold it... ");
            CountDown(6);
            Thread.Sleep(1000);
           

            Console.Write("And then, breathe out... ");
            CountDown(6);
            Thread.Sleep(1000);
            
            Console.WriteLine("");
            // Subtract the time taken for one cycle of the breathing exercise
            duration -= 19;
        }

        Console.Clear();
        Console.WriteLine($"Well done!! :) That is amazing!!\n\n You have completed {total} seconds of the Breathing Activity. ");
        Spinner(5);
        Thread.Sleep(3000);
        Console.Clear();
    }
}