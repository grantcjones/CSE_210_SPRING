using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Samuel Bennet", "Multiplication", "7.3", "8-19");
        WriteLine(assignment1.GetSummary());
        WriteLine(assignment1.GetHomeworkList());

        WriteLine("");

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        WriteLine(writingAssignment1.GetSummary());
        WriteLine(writingAssignment1.GetWritingInformation());

    }
}