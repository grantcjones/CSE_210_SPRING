using static System.Console;

public class Eternal : Goal{
    // private int _totalCompletions;

    public Eternal(int points, string title)
        : base(points, title) {
            // _totalCompletions = 0;
        }

    public override void DisplayGoal() {
        WriteLine($"------- {GetTitle()} Points: {GetPoints()}");
    }

    public override int Complete() {
        // _totalCompletions += 1;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }
}