using static System.Console;

public class Repeated : Goal{
    private int _completions;
    private int _completionGoal;

    public Repeated(int points, string title, int completionGoal)
        : base(points, title) {
            _completionGoal = completionGoal;
        }

    public override void DisplayGoal() {
        if (_completions <= 9 && _completionGoal > 9) {
            WriteLine($"[{_completions}/{_completionGoal}]- {GetTitle()} Points: {GetPoints()}");
        }
        else if (_completions > 9 && _completionGoal > 9) {
            WriteLine($"[{_completions}/{_completionGoal}] {GetTitle()} Points: {GetPoints()}");
        }
        else {
            WriteLine($"[{_completions}/{_completionGoal}]-- {GetTitle()} Points: {GetPoints()}");
        }
    }

    public override int Complete() {
        
        if (_completions < _completionGoal) {
            _completions += 1;
            if (_completions == _completionGoal) {
                WriteLine("Goal completed!");
                return GetPoints() * 2;
            }
            return GetPoints();
        }
        else {
            WriteLine("This goal has already been completed.\n");
            return 0;
        }
    }

    public void SetCompletions(int initialize) {
        _completions = initialize;
    }

    public int GetCompletions() {
        return _completions;
    }

    public int GetCompletionGoal() {
        return _completionGoal;
    }

    public override bool IsComplete() {
        if (_completions == _completionGoal) {
            return true;
        }
        else {
            return false;
        }
    }

}