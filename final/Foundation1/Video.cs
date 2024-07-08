using static System.Console;

public class Video {
    /*Used to create a 'video' object with a similar construction of YouTube videos
    (done without actual video files, specifically meant to demonstrate Abstraction)*/

    // Initialize Class Attributes
    string _title;
    string _author;
    int _length;
    List<Comment> _comments = [];

    // Constructor(s)
    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    // Class Behaviors
    public void DisplayDetails() {
        /*PUTS a summary of a videos 'details'*/
        WriteLine($"{_title}, {_author}, Length: {_length}");
    }

    public void AddComment(string commentAuthor, string commentContent) {
        /*Adds an individual comment to _comments*/
        Comment comment = new Comment(commentAuthor, commentContent);
        _comments.Add(comment);
    }

    public void DisplayComments() {
        /*Iterates through _comments and PUTS each one to the terminal 
        using the DisplayComment behavior from the Comment class.*/
        foreach (Comment comment in _comments) {
            comment.DisplayComment();
        }
    }

    public void CountComments() {
        /*PUTS total number of comments to terminal*/
        WriteLine($"Comments {_comments.Count()}:");
    }
}