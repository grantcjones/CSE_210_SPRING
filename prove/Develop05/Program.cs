using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Console;
using System.Text.Json;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void LoadFile(string filePath, ref int score, List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line by comma
                string[] parts = line.Split(',');


                if (parts.Length == 2) {
                    string type = parts[0].Trim();
                    string pointsStr = parts[1].Trim();
                    int points = Int32.Parse(pointsStr);

                    if (type == "Score") {
                        score = points;
                    }
                }
                else if (parts.Length > 0)
                {
                    string type = parts[0].Trim();
                    string title = parts[1].Trim();
                    int points = int.Parse(parts[2].Trim());

                    // if (type == "Score") {
                    //     score = int.Parse(parts[2].Trim());
                    // }    
                    if (type == "Repeated" && parts.Length == 5)
                    {
                        int completions = int.Parse(parts[3].Trim());
                        int completionGoal = int.Parse(parts[4].Trim());
                        Repeated repeated = new Repeated(points, title, completionGoal);
                        repeated.SetCompletions(completions);
                        repeateds.Add(repeated);
                    }
                    else if (type == "Eternal" && parts.Length == 3)
                    {
                        // int completions = int.Parse(parts[3].Trim());
                        eternals.Add(new Eternal(points, title));
                    }
                    else if (type == "Simple" && parts.Length == 4)
                    {
                        Simple newSimple = new Simple(points, title);
                        bool isComplete = bool.Parse(parts[3].Trim());
                        if (isComplete) {
                            newSimple.Complete();
                        }
                        simples.Add(newSimple);
                    }
                }
            }
        }
    }

    static void SaveToFile(string filePath, int score, List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {

        List<string> goals = new List<string>();
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            
            foreach (Simple goal in simples) {
                goals.Add($"Simple, {goal.GetTitle()}, {goal.GetPoints()}, {goal.IsComplete()}");
            }
            foreach (Eternal goal in eternals) {
                goals.Add($"Eternal, {goal.GetTitle()}, {goal.GetPoints()}");
            }
            foreach (Repeated goal in repeateds) {
                goals.Add($"Repeated, {goal.GetTitle()}, {goal.GetPoints()}, {goal.GetCompletions()}, {goal.GetCompletionGoal()}");
            }

            writer.WriteLine($"Score, {score}"); // Add points as first line
            foreach (string line in goals) { // Add each Goal line by line
                writer.WriteLine(line);
            }

            simples.Clear();
            eternals.Clear();
            repeateds.Clear();
        }

    }

    static void DisplayAll(List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {
        WriteLine(" Simple Goals");
            foreach (Simple goal in simples) {
                goal.DisplayGoal();
        }
        WriteLine(" Eternal Goals");
            foreach (Eternal goal in eternals) {
                goal.DisplayGoal();
            }
        WriteLine(" Repeated Goals");
            foreach (Repeated goal in repeateds) {
                goal.DisplayGoal();
            }
    }

    static void Main(string[] args)
    {
        List<Simple> simples = [];
        List<Eternal> eternals = [];
        List<Repeated> repeateds = [];
        int totalPoints = 0;
        List<string> rewards = ["Add $5.00 to fun money: 50 points.", "1 hour of game-time: 15 points.", "Go out to eat (max $30): 100 points."];

        LoadFile("C:/Users/Grant Jones/Desktop/CSE_210/CSE_210_SPRING/prove/Develop05/goalfile.txt", ref totalPoints, simples, eternals, repeateds);

        string Menu() { //TODO improve welcome message and menu
            WriteLine("1. Display Exisiting Goals.");
            WriteLine("2. Save and Exit.");
            WriteLine("3. Mark Off Goal.");
            WriteLine("4. Display Score.");
            WriteLine("5. Create Goal.");
            WriteLine("6. Spend Points.");
            WriteLine("7. Exit Without Saving.");
            
            Write("Selection: ");
            return ReadLine();
        }
        WriteLine("Welcome to the Goal Program.\n");

        string choice = Menu();
        while (choice != "7") {
            
            switch(choice) {
                case "1": // Display exisiting goals
                    WriteLine("");
                    DisplayAll(simples, eternals, repeateds);
                    WriteLine("");
                break;

                case "2": // Save and quit
                    SaveToFile("C:/Users/Grant Jones/Desktop/CSE_210/CSE_210_SPRING/prove/Develop05/goalfile.txt", totalPoints, simples, eternals, repeateds);
                    Environment.Exit(0);// Exit program
                break;

            case "3": // Mark off goal
                WriteLine("\n1. Simple Task");
                WriteLine("2. Eternal Task");
                WriteLine("3. Repeated Task");

                while (true)
                {
                    Write("Select task category: ");
                    string select = ReadLine();

                    if ((select == "1" && simples.Count == 0) || (select == "2" && eternals.Count() == 0) || (select == "3" && repeateds.Count() == 0)) {
                        WriteLine("There are no tasks available in this category.\n");
                        break;
                    }
                    
                    int count = 0;
                    switch (select)
                    {
                        case "1":
                            // Mark off Simple Goal
                            foreach (Simple simple in simples)
                            {
                                count++;
                                Write($"{count} ");
                                simple.DisplayGoal();
                            }

                            WriteLine("");
                            Write("Select goal completed: ");
                            string selectSimpleStr = ReadLine();

                            // if (selectSimpleStr == "cancel") {
                            //     WriteLine("");
                            //     break;
                            // }

                            if (int.TryParse(selectSimpleStr, out int selectedSimple) && selectedSimple >= 1 && selectedSimple <= simples.Count)
                            {
                                totalPoints += simples[selectedSimple - 1].Complete(); // Adjust index to zero-based
                            }
                            else
                            {
                                WriteLine("Invalid selection. Please try again.");
                                continue; // Restart the loop to prompt again
                            }
                            break;

                        case "2":
                            // Mark off Eternal Goal
                            foreach (Eternal eternal in eternals)
                            {
                                count++;
                                Write($"{count} ");
                                eternal.DisplayGoal();
                            }

                            Write("Select goal completed: ");
                            string selectEternalStr = ReadLine();
                            if (int.TryParse(selectEternalStr, out int selectedEternal) && selectedEternal >= 1 && selectedEternal <= eternals.Count)
                            {
                                totalPoints += eternals[selectedEternal - 1].Complete(); // Adjust index to zero-based
                            }
                            else
                            {
                                WriteLine("Invalid selection. Please try again.");
                                continue; // Restart the loop to prompt again
                            }
                            break;

                        case "3":
                            // Mark off Repeated Goal
                            foreach (Repeated repeated in repeateds)
                            {
                                count++;
                                Write($"{count} ");
                                repeated.DisplayGoal();
                            }

                            Write("Select goal completed: ");
                            string selectRepeatedStr = ReadLine();
                            if (selectRepeatedStr == "cancel") {
                                WriteLine("");
                            }
                            if (int.TryParse(selectRepeatedStr, out int selectedRepeated) && selectedRepeated >= 1 && selectedRepeated <= repeateds.Count)
                            {
                                totalPoints += repeateds[selectedRepeated - 1].Complete(); // Adjust index to zero-based
                            }
                            else
                            {
                                WriteLine("Invalid selection. Please try again.");
                                continue; // Restart the loop to prompt again
                            }
                            break;

                        default:
                            WriteLine("Incorrect selection, please try again: ");
                            continue; // Restart the loop to prompt again
                    }

                    // Break out of the loop if a valid selection was made
                    break;
                }
                WriteLine("");
                break;

                case "4": // Display score

                    WriteLine($"\nScore: {totalPoints}\n");
                break;

                case "5": // Create goal
                    WriteLine("\n     Goal Creation");
                    WriteLine("1. Simple Goal");
                    WriteLine("2. Eternal Goal");
                    WriteLine("3. Repeated Goal");

                    Write("Select goal type: ");
                    string goalType = ReadLine();

                    Write("Set Title: ");
                    string title = ReadLine();

                    Write("Set Points: ");
                    string pointsStr = ReadLine();
                    int points = Int32.Parse(pointsStr);

                    switch(goalType) {
                        case "1":
                            Simple simple = new Simple(points, title);
                            simples.Add(simple);
                        break;

                        case "2":
                            Eternal eternal = new Eternal(points, title);
                            eternals.Add(eternal);
                        break;

                        case "3":
                            Write("Set number of times goal must be completed (2-9): ");
                            string requiredCompletionsStr = ReadLine();
                            int requiredCompletions = Int32.Parse(requiredCompletionsStr);
                            Repeated repeated = new Repeated(points, title, requiredCompletions);
                            repeateds.Add(repeated);
                        break;
                    }
                    WriteLine("");
                break;

                case "6": // Spend points
                    int itemCount = 0;
                    WriteLine("");
                    foreach (string item in rewards) {
                        itemCount ++;
                        Write($"{itemCount}. ");
                        WriteLine(item);
                    }
                    Write("Please select an item from the shop: ");
                    string purchase = ReadLine();

                    bool sufficientFunds(int wallet, int price) { // Ensure player can make purchases
                        if (wallet >= price) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }

                    switch(purchase) {
                        case "1": // Fun money, 50 pts
                            if (sufficientFunds(totalPoints, 50)) {
                                totalPoints -= 50;
                                WriteLine("Enjoy your $5.00 fun money!");
                                WriteLine($"Remaining point balance: {totalPoints}\n");
                            }
                            else {
                                WriteLine("Insufficient funds.");
                                WriteLine($"Current point balance: {totalPoints}\n");
                            }
                        break;

                        case "2": // 1 hour game-time, 15 pts
                            if (sufficientFunds(totalPoints, 15)) {
                                totalPoints -= 15;
                                WriteLine("Enjoy your 1 hour of game-time!");
                                WriteLine($"Remaining point balance: {totalPoints}\n");
                            }
                            else {
                                WriteLine("Insufficient funds.");
                                WriteLine($"Current point balance: {totalPoints}\n");
                            }

                        break;

                        case "3": // Eat out, 100 pts
                            if (sufficientFunds(totalPoints, 100)) {
                                totalPoints -= 100;
                                WriteLine("Enjoy eating out!");
                                WriteLine($"Remaining point balance: {totalPoints}\n");
                            }
                            else {
                                WriteLine("Insufficient funds.");
                                WriteLine($"Current point balance: {totalPoints}\n");
                            }

                        break;
                    }


                break;

                case "7": // Quit without saving
                    // Just here to show the case, will terminate loop if selected.
                break;
            }
            choice = Menu();
        }
        

        
    }
}
