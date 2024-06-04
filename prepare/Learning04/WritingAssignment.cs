using System;
using static System.Console;

class WritingAssignment : Assignment {
    // Attributes
    private string _title { get; set; }

    // Constructors
    public WritingAssignment() : base() {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        _title = title;
    }

    // Methods/Behaviors
    public string GetWritingInformation() {
        return $"{_title} by {GetStudentName()}";
    }
}