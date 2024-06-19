using System;
using static System.Console;

public class Listing : Activity {

    // Attributes
    private List<string> _prompts = 
        [
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?", 
            "Who are some of your personal heroes?"
        ];

    
    // Constructor(s)
    public Listing(string title, string description, int duration) 
        : base(title, description, duration) 
    {
        
    }

    public Listing(string title, string description) 
        : base(title, description) {

    }

    // Behaviors/Methods
    public string GetPrompt() {
        int length = _prompts.Count();
        Random random = new Random();
        return _prompts[random.Next(0, length)]; 
    }

    public void CountDown() {
        Write("6\b");
        Thread.Sleep(1000);
        Write("5\b");
        Thread.Sleep(1000);
        Write("4\b");
        Thread.Sleep(1000);
        Write("3\b");
        Thread.Sleep(1000);
        Write("2\b");
        Thread.Sleep(1000);
        Write("1\b \b");

    }

    public void RunListing(int duration) {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DisplayAnimation();
        WriteLine(GetPrompt());
        WriteLine("");

        CountDown();

        WriteLine("");
        
        int count = 0;
        while(DateTime.Now < endTime) {
            
            string answer = ReadLine();
            WriteLine("");
            if (!string.IsNullOrWhiteSpace(answer)) {
                count ++;
            }
        }

        WriteLine($"Number of items listed: {count}");
    }
}