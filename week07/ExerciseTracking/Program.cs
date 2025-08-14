using System;

class Program
{
    static void Main(string[] args)
    {
        // Creat a list to handle Activities
        List<Activity> activities = new List<Activity>();

        // Create activities
        Running running = new Running(new DateTime(2025, 08, 13), 30, 3.0); // 3 miles run in 30 minutes
        activities.Add(running);

        Cycling cycling = new Cycling(new DateTime(2025, 08, 13), 45, 15.0); // 15 mph cycling for 45 minutes
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateTime(2025, 08, 13), 20, 10); // 10 laps swimming in 20 minutes
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