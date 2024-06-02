using System;
using static System.Console;
// using static System.Random;

class Prompt
{
    // Attribute(s)
    private List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
    // Constructors
    public Prompt() {

    }

    public List<string> getStrings() {
        return _prompts;
    }

    public void SetPrompts(List<string> value) {
        _prompts = value;
    }

    public string getPrompt() {
        Random random = new Random();
        int myRandom = random.Next(0, 6);
        string prompt = _prompts[myRandom];
        return prompt;
    }

    // public void DisplayPrompt() {
    //     Random random = new Random();
    //     int myRandom = random.Next(6);
    //     string prompt = _prompts[myRandom];
    //     WriteLine(prompt);
    // }
}
