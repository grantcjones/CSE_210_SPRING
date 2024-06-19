
using System;
using System.ComponentModel;
using static System.Console;

public class Breathing : Activity {
    // Attributes

    // Constructor(s)
    public Breathing(string title, string description, int duration)
        : base(title, description, duration)
    {
        
    }

    public Breathing(string title, string description)
        : base(title, description) {

        }

    public void BreathingAnimation()
    {
        Write("v('.')v\b\b\b\b\b\b\b");
        Thread.Sleep(1000);
        Write("<('o')>\b\b\b\b\b\b\b");
        Thread.Sleep(1000);
        Write("<('O')>\b\b\b\b\b\b\b");
        Thread.Sleep(2000);
        Write("<('o')>\b\b\b\b\b\b\b");
        Thread.Sleep(1000);
        Write("v('.')v\b\b\b\b\b\b\b");
       }

    public void RunBreathing(int duration) { //TODO Fix runtime

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DisplayAnimation();

        while(DateTime.Now < endTime) {
            Clear();
            Write("Breathe in  ");
            BreathingAnimation();
            Clear();

            Write("Breathe out ");
            BreathingAnimation();
            Clear();            
        }

    }

}

