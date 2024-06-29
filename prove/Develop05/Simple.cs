using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

public class Simple : Goal{
    private bool _isComplete = false;

    public Simple(int points, string title) 
        : base(points, title) {

        }

    public override void DisplayGoal() {
        if (_isComplete) {
            WriteLine($"[x]---- {GetTitle()} Points: {GetPoints()}");
        }
        else {
            WriteLine($"[ ]---- {GetTitle()} Points: {GetPoints()}");
        }
    }

    public override int Complete() {
        if (!_isComplete) {
            _isComplete = true;
            return GetPoints();
        }
        else {
            WriteLine("This goal has already been completed.\n");
            return 0;
        }
    }

    public override bool IsComplete() {
        return _isComplete;
    }

    
}