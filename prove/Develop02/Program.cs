using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string time = DateTime.Now.ToString("hh:mm:ss tt");
        List<string> _entries = new List<string>();

        // DisplaMenu //
        int? option = null;
        while (option != 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome. What would you like to do?");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Current Entries");
            Console.WriteLine("3. Load Previous Journal");
            Console.WriteLine("4. Save Current Journal");
            Console.WriteLine("5. Clear Current Jounal");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option from 1 - 5?: ");
            
            option = int.Parse(Console.ReadLine());

            // Opt.1 - New Journal Entry //
            if (option == 1)
            {
                Entry newEntry = new Entry();
                PromptGen promptGenerator = new PromptGen();
                string entry = newEntry.JournalEntry();
                _entries.Add(entry);

                // save entry //
                string fileName = "journal.txt";
                try
                {
                    using (TextWriter tw = new StreamWriter(fileName, true))
                    {
                        tw.WriteLine(entry);
                    }
                    Console.WriteLine($" Journal entry Successfully saved {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Journal entries saving Error: {ex.Message}");
                }
            
            }
 
            // Opt.2 - Display current entry // 
            else if (option == 2)
            {
                foreach (string entry in _entries)
                {
                    Console.WriteLine(entry);
                }
            }
             // Opt.3 - Load previous entry //
            else if (option == 3)
            {
              // load last entry // 
                string[] loadedEntries = File.ReadAllLines("journal.txt");

                // display last entry //
                Console.WriteLine("Last Entry: ");
                Console.WriteLine(loadedEntries[loadedEntries.Length - 1]);
                
                foreach (string entry in loadedEntries)
                {
                    _entries.Add(entry);
                }
                Console.WriteLine("Journal loaded successfully");
            }
           // Opt.4 - Save option //
            else if (option == 4)
            {
               string fileName = "journal.txt";
               try
               {
                    using (TextWriter tw = new StreamWriter(fileName))
                    {
                     foreach (string letter in _entries) tw.WriteLine(letter);
                    }
                    Console.WriteLine($" Journal entry Successfully saved {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Journal entries saving Error: {ex.Message}");
                }    
            }

            // Opt.5 - Clear option //
            else if (option == 5)
            {
                string answer = "";
                Console.WriteLine("Are you sure you want to delete the current journal?");
                Console.Write("This could not be undone (yes/no)! ");
                answer = Console.ReadLine();

                // Confirms to clear an entries //
                if (answer == "yes")
                {
                    _entries.Clear();
                    Console.WriteLine("Journal has been deleted");
                }

                else
                {
                    Console.WriteLine("Journal has been logged");
                }
            }

            // End Program //
            else if (option == 6)
            {
                Console.WriteLine("Goodbye. Thank you for the time!");
            }

            // If input is not valid //
            else
            {
                Console.WriteLine("Please enter a valid prompt, enter a number between 1 - 5.");
                option = null;
            }

        }
    }
}