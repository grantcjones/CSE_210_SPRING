using System.ComponentModel;
using static System.Console;

public abstract class Goal{
    private int _points;
    private string _title;

    public Goal(int points, string title) {
        _points = points;
        _title = title;
    }

    public virtual void DisplayGoal() {
        WriteLine($"   {_title} {_points}");
    }

    public abstract int Complete();

    public string GetTitle() {
        return _title;
    }

    public int GetPoints() {
        return _points;
    }

    public virtual bool IsComplete() {
        return false;
    }
}