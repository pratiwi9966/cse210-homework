using System;

class Program
{
    static void Main(string[] args)
    {
        // Creat a list to handle Activities
        List<Activity> activities = new List<Activity>();

        // Create activities
        Running running = new Running(new DateTime(2025, 08, 13), 60, 6.2); // 10 km in 60 min (about 6.2 miles)
        activities.Add(running);

        Cycling cycling = new Cycling(new DateTime(2025, 08, 14), 120, 18.0); // 18 mph cycling for 2 hours
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateTime(2025, 08, 15), 40, 20); // 20 laps in 40 minutes
        activities.Add(swimming);

        // Display summary for each activity
        Console.WriteLine();
        Console.WriteLine("Here are the activities: ");
        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
        Console.WriteLine();
    }
}