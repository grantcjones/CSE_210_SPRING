using System;
using System.Collections.Generic;
using static System.Console;
using System.Threading;
using System.Runtime.InteropServices;

public class Reflection : Activity {

    // Attributes
    private List<string> _listPrompts = new List<string> {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private List<string> _listQuestions = new List<string> {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    // Constructor(s)
    public Reflection(string title, string description, int duration) 
        : base(title, description, duration)
    {
        
    }

    public Reflection(string title, string description) 
        : base(title, description)
    {
        
    }

    // Behaviors/Methods
    public string GetPrompt() {
        Random random = new Random();
        int index = random.Next(_listPrompts.Count);
        return _listPrompts[index];
    }

    public List<string> GetQuestions() {
        List<string> tempList = new List<string>(_listQuestions); // Create a copy of the list
        tempList.ShuffleList();
        return tempList;
    }

    public void RunReflection(int duration) {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DisplayAnimation();

        List<string> shuffled = GetQuestions();
        string prompt = GetPrompt();
        WriteLine($"Prompt: {prompt}\n");
        DisplayAnimation();

        List<string> questions = GetQuestions();

        int questionIndex = 0;
        while(DateTime.Now < endTime) {
   
                WriteLine($"{questions[questionIndex]}");
                DisplaySpinner();
                WriteLine("");

                questionIndex ++;

                if (questionIndex >= questions.Count()) {
                    questionIndex = 0;
                }
        }
    }
}
