using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("987 Main St", "Cityville", "Stateville", "12345");
        Lecture lectureEvent = new Lecture("Lecture Title", "C# Lecture", "2024-03-01", "15:00", address1, "John Doe", 50);

        Address address2 = new Address("456 Park Ave", "Nashville", "Stateville", "Stateville", "67890");
        Reception receptionEvent = new Reception("Reception Title", "C# Reception", "2024-03-05", "18:00", address2, "rsvp@example.com");

        Address address3 = new Address("321 Nature Ln", "Conway", "Stateville", "54321");
        Gathering outdoorEvent = new Gathering("Outdoor Event", "Classic Weather", "2024-03-10", "19:30", address3);

        Event[] events = {lectureEvent, receptionEvent, outdoorEvent};

        foreach (Event evnt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evnt.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(evnt.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(evnt.GetShortDescription());
            Console.WriteLine("\n" + new string('=', 50) + "\n");
        }
    }
}