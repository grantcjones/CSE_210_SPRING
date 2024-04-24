using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write("What is your first name?: ");
        string firstName = ReadLine();

        Write("What is your last name?: ");
        string lastName = ReadLine();

        WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");


    }
}