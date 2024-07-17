using System;
using static System.Console;
// using static System.Random;

public class Prompt
{
    // Attribute(s)
    private List<string> _prompts = new List<string> {
     "Who was the most interesting person I interacted with today?",
     "What was the best part of my day?", 
     "How did I see the hand of the Lord in my life today?", 
     "What was the strongest emotion I felt today?", 
     "If I had one thing I could do over today, what would it be?",
     "What could I have done to be a better disciple?",
     "Was there somebody I could have helped in need?"};

    private string _prompt;
    // Constructors
    public Prompt() {
        _prompt = GeneratePrompt();
    }

    public Prompt(string setPrompt) {
        _prompt = setPrompt;
    }

    public List<string> getStrings() {
        return _prompts;
    }

    public string GeneratePrompt() {
        Random random = new Random();
        int myRandom = random.Next(0, 7);
        string prompt = _prompts[myRandom];
        return prompt;
    }

    public string GetPrompt() {
        return _prompt;
    }

}
