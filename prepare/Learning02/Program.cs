using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _company = "Microsoft",
            _title = "Software Engineer",
            _startYear = 2018,
            _endYear = 2021
        };

        Job job2 = new Job
        {
            _company = "Apple",
            _title = "Manager",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume resume1 = new Resume
        {
            _name = "John Bytheway",
        };

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}