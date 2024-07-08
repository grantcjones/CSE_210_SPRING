using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = []; // Used to store any Activity object and sub-class objects

        // Create Example Activity Subclass Objects
        Running running = new Running("6/17/24", 30, 4.8); // date, duration, distance km
        Cycling cycling = new Cycling("6/18/24", 45, 30); // date, duration, speed kph
        Swimming swimming = new Swimming("6/19/24", 60, 25); // date, duration, laps (50 meters)

        // Add sub-class objects to activities list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Iterate through and display sub-class object summaries using Activity class behavior GetSummary
        foreach (Activity activity in activities) {
            activity.GetSummary();
            WriteLine();
        }
    }
}