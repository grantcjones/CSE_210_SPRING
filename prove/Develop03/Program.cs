using System;
using System.Linq.Expressions;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {   
        static void Run(Reference reference) {
            Write("Enter text: ");
            string text = ReadLine();
            Scripture scripture = new Scripture(text, reference);
            do {
                Clear();
                WriteLine(scripture.Display());

                WriteLine("\nPress enter to continue or type 'exit' to exit");
                string choice = ReadLine();
                
                if (choice == "exit") {
                    return;
                }
                else if (choice.ToLower() == "") {
                    scripture.HideWords();
                }

            } while (!scripture.IfAllHidden());
        }

        WriteLine("Welcome to the scripture memorizer. Please begin.");

        Write("Enter Book name (ex: 2 Nephi): ");
        string book = ReadLine();
        Write("Enter the chapter number: ");
        string chpt = ReadLine();

        Write("Is there more than one verse? (y/n): ");
        string masVerse = ReadLine();
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor - 1);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor - 1);        

        if (masVerse.ToLower() == "y") {
            Write("Enter first verse number: ");
            string firstVerse = ReadLine();
            Write("Enter second verse number: ");
            string secondVerse = ReadLine();
            Reference reference = new Reference(book, chpt, firstVerse, secondVerse);
            Run(reference);
        }
        else {
            Write("Enter first verse number: ");
            string firstVerse = ReadLine();
            Reference reference = new Reference(book, chpt, firstVerse);
            Run(reference);
        }

        Clear();

    }
}