using System;
using System.Net;
using static System.Console;

public class Activity {
    // Attributes
    // private string _welcomeMessage{ get; set; }
    // private string _congratsMessage{ get; set; }
    private string _title;
    private string _description{ get; set; }
    private int _duration{ get; set; }
    private int _timeCounter = 4000;

    // Constructor(s)
    public Activity(string title, string description, int duration) {
        _title = title;
        _description = description;
        _duration = duration;
    }

    public Activity(string title, string description) {
        _title = title;
        _description = description;
    }

    public Activity() {

    }

    public void DisplayAnimation() {
        while(_timeCounter >= 0) {
            int delay = 320;
            Write(" <('-'<)\b\b\b\b\b\b\b\b");
            Thread.Sleep(delay);
            Write(" ^('-')^\b\b\b\b\b\b\b\b");
            Thread.Sleep(delay);
            Write(" (>'-')>\b\b\b\b\b\b\b\b");
            Thread.Sleep(delay);
            Write(" ^('-')^\b\b\b\b\b\b\b\b");
            Thread.Sleep(delay);
            _timeCounter = _timeCounter - 1000;
        }
    }

    public void DisplaySpinner() {
        int runtime = 6000;
            while(runtime >= 0) {
                int delay = 100;
                Write("/\b");
                Thread.Sleep(delay);
                Write("-\b");
                Thread.Sleep(delay);
                Write("\\\b");
                Thread.Sleep(delay);
                Write("|\b\b");
                Thread.Sleep(delay);
                runtime = runtime - 1000;
            Write(" \b");
        }
    }

    public void SetDuration() {
        WriteLine("How long do you want to do the activity in seconds?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public int GetDuration() {
        return _duration;
    }

    public void Start() {
        DisplayAnimation();
        WriteLine($"Welcome to the {_title} Activity");
        WriteLine($"This activity will help you {_description}");
    }

    public void OnEnd() {
        WriteLine($"Congradulations! You have completed the {_title} Activity for {_duration} seconds.");
        DisplayAnimation();
    }

}