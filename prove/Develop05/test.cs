// using System.Formats.Asn1;
// using System.Reflection;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;
// using static System.Console;

// public class Program {

//         static void LoadFile(string filePath, int score, List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {
//             using (StreamReader reader = new StreamReader(filePath))
//             {
//                 string line;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     // Split the line by comma
//                     string[] parts = line.Split(',');

//                     if (parts.Length == 2) {
//                         string type = parts[0].Trim();
//                         string pointsStr = parts[1].Trim();
//                         int points = Int32.Parse(pointsStr);

//                         if (type == "Score") {
//                             score = points;
//                         }
//                     }
//                     else if (parts.Length > 0)
//                     {
//                         string type = parts[0].Trim();
//                         string title = parts[1].Trim();
//                         int points = int.Parse(parts[2].Trim());

//                         if (type == "Repeated" && parts.Length == 5)
//                         {
//                             int completions = int.Parse(parts[3].Trim());
//                             int completionGoal = int.Parse(parts[4].Trim());
//                             Repeated repeated = new Repeated(points, title, completionGoal);
//                             repeated.SetCompletions(completions);
//                             repeateds.Add(repeated);
//                         }
//                         else if (type == "Eternal" && parts.Length == 3)
//                         {
//                             // int completions = int.Parse(parts[3].Trim());
//                             eternals.Add(new Eternal(points, title));
//                         }
//                         else if (type == "Simple" && parts.Length == 4)
//                         {
//                             Simple newSimple = new Simple(points, title);
//                             bool isComplete = bool.Parse(parts[3].Trim());
//                             if (isComplete) {
//                                 newSimple.Complete();
//                             }
//                             simples.Add(newSimple);
//                         }
//                     }
//                 }
//             }
//         }

//         static void SaveToFile(string filePath, int score, List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {

//             List<string> goals = new List<string>();
//             Directory.CreateDirectory(Path.GetDirectoryName(filePath));

//             using (StreamWriter writer = new StreamWriter(filePath))
//             {
                
//                 foreach (Simple goal in simples) {
//                     goals.Add($"Simple, {goal.GetTitle()}, {goal.GetPoints()}, {goal.IsComplete()}");
//                 }
//                 foreach (Eternal goal in eternals) {
//                     goals.Add($"Eternal, {goal.GetTitle()}, {goal.GetPoints()}");
//                 }
//                 foreach (Repeated goal in repeateds) {
//                     goals.Add($"Repeated, {goal.GetTitle()}, {goal.GetPoints()}, {goal.GetCompletions()}, {goal.GetCompletionGoal()}");
//                 }

//                 writer.WriteLine($"Score, {score}"); // Add points as first line
//                 foreach (string line in goals) { // Add each Goal line by line
//                     writer.WriteLine(line);
//                 }

//                 simples.Clear();
//                 eternals.Clear();
//                 repeateds.Clear();
//             }

//         }

//         static void DisplayAll(List<Simple> simples, List<Eternal> eternals, List<Repeated> repeateds) {
//             WriteLine(" Simple Goals");
//                 foreach (Simple goal in simples) {
//                     goal.DisplayGoal();
//             }
//             WriteLine(" Eternal Goals");
//                 foreach (Eternal goal in eternals) {
//                     goal.DisplayGoal();
//                 }
//             WriteLine(" Repeated Goals");
//                 foreach (Repeated goal in repeateds) {
//                     goal.DisplayGoal();
//                 }
//         }

//     static void Main(string[] args) {

        
//         List<Simple> simples = [];
//         List<Eternal> eternals = [];
//         List<Repeated> repeateds = [];
//          // Initialized for open and save
//         int pointsToken = 800;
//         string fileName = "C:/Users/Grant Jones/Desktop/CSE_210/CSE_210_SPRING/prove/Develop05/test.txt";

//         // Simple object test
//         Simple simple = new Simple(25, "Simple Goal");
//         simples.Add(simple);

//         // Simple object test
//         Eternal eternal = new Eternal(15, "Eternal Goal");
//         eternals.Add(eternal);

//         // Repeated generation control test
//         Repeated repeated1 = new Repeated(15, "Repeated Goal 1", 5);
//         repeateds.Add(repeated1);

//         // Repeated return length variation tests
//         Repeated repeated2 = new Repeated(15, "Repeated Goal 2", 15); // [<9/<9]
//         repeateds.Add(repeated2);

//         Repeated repeated3 = new Repeated(15, "Repeated Goal 3", 15); // [<9/>9]
//         for (int i =0; i < 9; i++) {
//             repeated3.Complete();
//         }
//         repeateds.Add(repeated3);

//         Repeated repeated4 = new Repeated(15, "Repeated Goal 4", 15); // [>9/>9]
//         for (int i = 0; i < 14; i++) {
//             repeated4.Complete();
//         }
//         repeateds.Add(repeated4);
        
//         // DisplayGoals Test
//         DisplayAll(simples, eternals, repeateds);
//         WriteLine(pointsToken);

//         // Save File Test
//         SaveToFile(fileName, pointsToken, simples, eternals, repeateds);

//         Write("Continue?: ");
//         string cont = ReadLine();

//         // Load File Test
//         LoadFile(fileName, pointsToken, simples, eternals, repeateds);
//         DisplayAll(simples, eternals, repeateds);
//         WriteLine(pointsToken);

//             // // Overwrite the file


//     }
// }