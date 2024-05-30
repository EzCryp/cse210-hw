using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        float percentage = float.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }        
        else if (percentage >= 80)
        {
            letter = "B";
        }       
        else if (percentage >= 70)
        {
            letter = "C";
        }       
        else if (percentage >= 60)
        {
            letter = "D";
        }       
        else
        {
            letter = "F";
        }       

        Console.WriteLine($"Your letter grade is {letter}.");

        // conditional statement to determine if the student passed the class
        // if the student's percentage is greater than or equal to 70 but not more than 80, the student passed the class
        if (percentage >= 70 && percentage < 80)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        // if the student's percentage is greater than or equal to 80 but not more than 90, the student is doing great
        else if (percentage >= 80 && percentage < 90)
        {
            Console.WriteLine("You are doing great. You can make your grade even better next time!");
        }
        // if the student's percentage is greater than or equal to 90 but not more than 100, the student is doing excellent
        else if (percentage >= 90 && percentage <= 100)
        {
            Console.WriteLine("You are doing excellent! Keep up the good work!");
        }

        //else statement to display a message if the student did not pass the class
        else
        {
            Console.WriteLine("You did not pass the class. Try again next time!");
        }

    }
}