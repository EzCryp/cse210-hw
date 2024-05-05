using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int persentage = int.Parse(answer);

        string letter = "";

        if (persentage >= 90)
        {
            letter = "A";
        }        
        else if (persentage >= 80)
        {
            letter = "B";
        }       
        else if (persentage >= 70)
        {
            letter = "C";
        }       
        else if (persentage >= 60)
        {
            letter = "D";
        }       
        else
        {
            letter = "F";
        }       

        Console.WriteLine($"Your letter grade is {letter}.");

        if (persentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Try again next time!");
        }

    }
}