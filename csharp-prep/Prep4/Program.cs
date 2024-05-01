using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<int> myNumbers = new List<int>();

        WriteLine("Enter a list of numbers, type 0 when finished: ");
        Write("Enter an integer: ");
        string newNumStr = ReadLine();
        int newNum = int.Parse(newNumStr);

        while (newNum != 0) {
            myNumbers.Add(newNum);
            Write("Enter an integer: ");
            newNumStr = ReadLine();
            newNum = int.Parse(newNumStr);
        }

        myNumbers.Sort();

        // Print out list of sorted numbers
        foreach (int myNumber in myNumbers) {
            if (myNumbers.IndexOf(myNumber) != (myNumbers.Count() - 1)) {
                Write($"{myNumber}, ");
            }
            else {
                WriteLine($"{myNumber}");
            }
        }

        int sum = myNumbers.Sum();
        WriteLine($"The sum is : {sum}");

        double avg = myNumbers.Average();
        WriteLine($"The average is: {avg}");

        int max = myNumbers.Max();
        WriteLine($"The largest number is: {max}");
    }
}