using System;
using static System.Console;

class Assignment {
    // Attributes
    private string _studentName { get; set; }
    private string _topic { get; set; }

    // Constructors
    public Assignment() {

    }

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    // Methods/Behaviors
    public string GetSummary() {
        /*Returns a summary of the student and their assignment topic.*/ 
        return $"{_studentName} - {_topic}";
    }

    protected string GetStudentName() {
        return _studentName;
    }

}