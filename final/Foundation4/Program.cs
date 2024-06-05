using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Bicycle(new DateTime(2022, 11, 4), 20, 15.5),
            new Swimming(new DateTime(2022, 11, 5), 45, 10),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}