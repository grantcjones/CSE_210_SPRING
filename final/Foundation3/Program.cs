using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Create Example Class Objects
        Lectures lecture = new Lectures("Discourse on the absurdity of the Earth as a Globe", "Speech on the Flat-Earth Theory", "12/34/12", "12:00", "234 Wall Street, New York NY", "Austing Prowers", 360);
        Receptions reception = new Receptions("Wedding Reception", "Two people got married", "6/5/12", "3:15", "123 Street St, City State", "recpt@gmail.com");
        reception.AddGuest("Jim Curry"); // Demonstration of adding people to the rsvp, not important to the code and not utilized later.
        reception.AddGuest("Tim Ballin");
        Outdoor outdoor = new Outdoor("Hike", "Hiking Mt Helena", "3/14/12", "12:45", "344 Foothill Ln, City State", "Cloudy");
        
        // Displaying short, medium, and long detail displays for each event
        WriteLine("     Lecture Example:\n");
        lecture.ShortDisplay();
        WriteLine();
        lecture.StandardDisplay();
        WriteLine();
        lecture.DisplayFullDetails();
        WriteLine();

        WriteLine("     Reception Example:\n");
        reception.ShortDisplay();
        WriteLine("");
        reception.StandardDisplay();
        WriteLine("");
        reception.DisplayFullDetails();
        WriteLine();

        WriteLine("     Outdoor Example:\n");
        outdoor.ShortDisplay();
        WriteLine();
        outdoor.StandardDisplay();
        WriteLine();
        outdoor.DisplayFullDetails();
        WriteLine();
    }
}