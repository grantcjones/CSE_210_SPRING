using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome() {
            WriteLine("Welcome to the program!");
        }

        string PromptUserName() {
            Write("Please enter your name: ");
            string name = ReadLine();
            return name;
        }

        int PromptUserNumber() {
            Write("Please enter your favorite number: ");
            string numStr = ReadLine();
            int number = int.Parse(numStr);
            return number;
        }

        int SquareNumber(int value) {
            int newValue = value * value;
            return newValue;
        }
       
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        WriteLine($"{name}, the square of your number is {SquareNumber(number)}");   
    }
}