using System;
using static System.Console;

public class Job {

    public string _company;
    public string _title;
    public int _startYear;
    public int _endYear;

    public Job () {

    }

    public void DisplayDetails () {
        WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}