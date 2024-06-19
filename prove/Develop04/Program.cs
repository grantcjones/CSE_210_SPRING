using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();

        // activity.DisplayAnimation();
        
        WriteLine("Welcome to the Mindfulness App. ");
        activity.DisplayAnimation();
        WriteLine("Menu Options: ");
        WriteLine(" 1. Start Breathing Activity.");
        WriteLine(" 2. Start Reflecting Activity.");
        WriteLine(" 3. Start Listing Activity.");
        WriteLine(" 4. Quit.");
        Write("Select a choice from the menu: ");
        string choice = ReadLine();

        switch(choice) {
            case "1":
                Clear();
                Breathing breathing = new Breathing("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Start();
                breathing.SetDuration();
                breathing.RunBreathing(breathing.GetDuration());
                breathing.OnEnd();
                break;

            case "2":
                Clear();
                Reflection reflection = new Reflection("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.Start();
                reflection.SetDuration();
                reflection.RunReflection(reflection.GetDuration());
                reflection.OnEnd();
                break;

            case "3":
                Clear();
                Listing listing = new Listing("Listing", " reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Start();
                listing.SetDuration();
                listing.RunListing(listing.GetDuration());
                listing.OnEnd();
                break;

            case "4":
                // Exits
                break;
        }
    }
}
