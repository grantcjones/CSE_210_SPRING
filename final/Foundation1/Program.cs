using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Create Example Class Objects
        Video video1 = new Video("First Video", "El Primero", 30);
        video1.AddComment("Spazzy1", "first CommEnt");
        video1.AddComment("wISARDO", "thie're");
        video1.AddComment("Misty", "WHat is goi;gn on?");

        Video video2 = new Video("Second Video", "El Secundo", 24);
        video2.AddComment("Wackadoodle", "This is a better video");
        video2.AddComment("weeee", "WEEEEEEE");
        video2.AddComment("user@2", "This sisa bottedsad messge");

        Video video3 = new Video("Last Video", "El Ultimo", 12);
        video3.AddComment("AHHHHHH", "AHHHHHH");
        video3.AddComment("WHAAAA", "whaaaaa");
        video3.AddComment("name", "comment");

        // Add Example Class Objects to a list (videos)
        List<Video> videos = [];
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        // Iterate through 'videos' and use behaviors to display attribute information
        foreach (Video video in videos) {
            video.DisplayDetails();
            video.CountComments();
            video.DisplayComments();
            WriteLine("");
        }

    }
}