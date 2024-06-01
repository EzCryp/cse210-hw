using System;
using System.Threading;

abstract class Activity
{
    // Abstract method to be implemented by derived classes
    public virtual void Start()
    {
        Console.WriteLine("Get ready... "); //make it go away after 5 seconds
        Spinner(5);
        Console.WriteLine();
        Console.Clear();
    }

    protected void CountDown(int x)
    {
        string[] countDown = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"};
        x--;
        for (int i = x; i >= 0; i--)
        {
            Console.Write(countDown[i]);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine(" ");
    }

    protected void Spinner(int x)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        for (int i = 0; i < x*4; i++)
        {
            Console.Write(spinner[spinnerIndex % spinner.Length] + " ");
            spinnerIndex++;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine(" ");
    }

    protected int GetDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            // Spinner(5);
            

            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer value.");
        }
    }
}