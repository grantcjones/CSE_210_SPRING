using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Console;

public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume() {

    }

    public void DisplayResume () {
        WriteLine($"Name: {_name}");
        WriteLine($"Jobs:");
        foreach (Job job in _jobs) {
            job.DisplayDetails();
        }
    }
}