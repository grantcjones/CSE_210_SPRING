using static System.Console;

public class Comment {
    /*Creates a Comment object to be used in the Video class*/

    // Initialize Class Attributes
    string _author;
    string _content;

    // Constructor(s)
    public Comment(string author, string content) {

        _author = author;
        _content = content;
    }

    // Class Behaviors
    public void DisplayComment() {
        WriteLine($"    {_author}: {_content}");
    }
}
