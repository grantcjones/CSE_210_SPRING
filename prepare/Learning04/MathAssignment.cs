using System;
using static System.Console;

class MathAssignment : Assignment {
    // Attributes
    private string _textBookSection { get; set; }
    private string _problems { get; set; }

    // Constructors
    public MathAssignment() : base() {

    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic) {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // Methods/Behaviors
    public string GetHomeworkList() {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}