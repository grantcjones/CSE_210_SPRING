using System;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using static System.Console;

class Program
{
    static List<Entry> LoadFromFile(string filePath, Journal journal) {
        List<Entry> entries = new List<Entry>();

        if (File.Exists(filePath)) {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i += 4) {
                string date = lines[i];
                string promptText = lines[i + 1];
                string emotion = lines[i + 2];
                string input = lines[i + 3];

                int emotionalLevel = int.Parse(emotion);

                journal.NewEntry(input, date, emotionalLevel, new Prompt(promptText));
            }
        }

    return entries;
    }

    static void SaveToFile(string fileName, List<Entry> entries) {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        using (StreamWriter writer = new StreamWriter(filePath)) {
            foreach (Entry entry in entries) {
                writer.Write(entry.GetEntry());
            }
        }
    }

    static void Main(string[] args)
    {   
        WriteLine("Welcome to the Journal Program.\n");

        // Initialize Journal Object
        Journal journal = new Journal();

        // 'main' Code Loop
        do {
            WriteLine("Options: \n");

            WriteLine("1. Load Journal File.");
            WriteLine("2. Display Current Journal.");
            WriteLine("3. New Entry.");
            WriteLine("4. Save Journal.");
            WriteLine("5. Exit.");
            string choice = ReadLine();

            switch(choice) {
                case "1": // Load Journal from file
                    journal = new Journal();
                    Write("Enter filename: ");
                    string filename = ReadLine();
                    LoadFromFile(filename, journal);
                break;
                
                case "2": // Display Journal
                    WriteLine("");
                    journal.DisplayJournal();
                break;

                case "3": // Add new Entry in Journal  
                    Prompt prompt = new Prompt();

                    Write("\nEnter Date: ");
                    string date = ReadLine();

                    WriteLine($"Prompt: {prompt.GetPrompt()}\nRespose:");
                    string response = ReadLine();

                    Write("Enter your emotional level on a scale of 1-5, with 1 being low and 5 being high: ");
                    string emotion = ReadLine();

                    int emotionalLevel = int.Parse(emotion);

                    journal.NewEntry(response, date, emotionalLevel, prompt);
                break;

                case "4": // Save Journal to file
                    Write("What would you like to name the file?: ");
                    string filenameSave = ReadLine();
                    SaveToFile(filenameSave, journal.GetEntries());
                break;

                case "5": // Exit the program
                        WriteLine("Exiting the program.");
                        return; // Exit the Main method and terminate the program

                default: // Invalid input handling
                    WriteLine("Invalid choice. Please select an option from 1 to 5.");
                    break;        
            }
        } while(true);
        
        
    }
}
