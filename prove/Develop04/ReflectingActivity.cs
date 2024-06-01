using System;

class ReflectingActivity : Activity
{
    public override void Start()
    {
        base.Start();

        Console.WriteLine("Welcome to Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        
        int duration = GetDuration();
        int usedDuration = duration;
        Console.Clear();

        Random random = new Random();
        string[] prompts = {
            " \n *** Think of a time when you stood up for someone else. *** ",
            " \n *** Think of a time when you did something really difficult. *** ",
            " \n *** Think of a time when you helped someone in need. *** ",
            " \n *** Think of a time when you did something truly selfless. *** ",
            " \n *** Think of a time you felt powerful *** ",
            " \n *** Think of a time where you felt calm *** ",
            " \n *** Think of a time when you felt confident *** ",
            " \n *** Think of a time that you felt completely at peace *** "
        };
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt + "\n");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        CountDown(5);
        foreach (string question in questions)
        {
            Console.Write(question);
            Spinner(duration);
            usedDuration -= duration;
            if (usedDuration <= 0)
            {
                break;
            }
        }

        Console.WriteLine("Well done!! :) \nYou're awesome!!\n\n You have completed another {0} seconds of the Reflecting Activity", duration);
        Spinner(5);
        Thread.Sleep(3000);
        Console.Clear();
    }
}