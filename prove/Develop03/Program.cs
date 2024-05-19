using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference scriptureReference = new Reference("", , );
        Reference scriptureReference1 = new Reference("Ether", 12, 27);
        Reference scriptureReference2 = new Reference("Jacob", 1, 19);
        Reference scriptureReference3 = new Reference("Doctrine and Covenants", 88, 119);
        Reference scriptureReference4 = new Reference("Ephesian", 6, 12);

        // Scripture myScripture1 = new Scripture( scriptureReference
        Scripture myScripture1 = new Scripture( scriptureReference1, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        Scripture myScripture2 = new Scripture( scriptureReference2, "And we did magnify our office unto the Lord, taking upon us the responsibility, answering the sins of the people upon our own heads if we did not teach them the word of God with all diligence; wherefore, by laboring with our might their blood might not come upon our garments; otherwise their blood would come upon our garments, and we would not be found spotless at the last day.");
        Scripture myScripture3 = new Scripture( scriptureReference3, "Organize yourselves; prepare every needful thing; and establish a house, even a house of prayer, a house of fasting, a house of faith, a house of learning, a house of glory, a house of order, a house of God");
        Scripture myScripture4 = new Scripture( scriptureReference4, "For we wrestle not against flesh and blood, but against principalities, against powers, against the rulers of the darkness of this world, against spiritual wickedness in high places.");


        List<Scripture> scriptures = new List<Scripture> { myScripture1, myScripture2, myScripture3, myScripture4 };

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Scripture randomScripture = scriptures[index];

        Console.WriteLine(randomScripture.Reference.GetDisplayText());
        Console.WriteLine(randomScripture.GetDisplayText());

        // options to user
        Console.Write("\nPress 'h' to hide a word\nType 'quit' to quit\nType 'save' to save\nType 'l' to load from file: ");
        string input = Console.ReadLine();

     while (input.ToLower() != "quit" && !randomScripture.IsCompletelyHidden())
    
     {
    
    randomScripture.HideRandomWord(4);

    
    Console.Clear();
    Console.WriteLine(randomScripture.Reference.GetDisplayText());
    Console.WriteLine(randomScripture.GetDisplayText());

    
    Console.Write("\nPress 'h' to hide a word\nType 'quit' to exit\nType 's' to save\nType 'l' to load from file: ");
    input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        Console.WriteLine("Hope you had fun in the scripture mastery!");
        break;
    }
    else if (input.ToLower() == "save")
    {
        Console.Write("Enter file name to save: ");
        string saveFile = Console.ReadLine();
        randomScripture.SaveFile(saveFile);
    }
    else if (input.ToLower() == "load")
    {
        Console.Write("Enter file name to load from: ");
        string loadFile = Console.ReadLine();
        randomScripture.LoadFile(loadFile);
    }  
    }
    }
    
}