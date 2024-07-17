using System.Runtime.CompilerServices;
using static System.Console;

public class Journal {
    private List<Entry> _entries = [];

    public Journal() {

    }

    public void NewEntry(string input, string date, int emotionalLevel, Prompt prompt ) {
        /*Used to add an object to Journal object's list
        Takes NO args*/
        _entries.Add(new Entry(input, date, emotionalLevel, prompt));
    }

    public void DisplayJournal() {
        foreach (Entry entry in _entries) {
            entry.DisplayEntry();
        }
    }

    public List<Entry> GetEntries() {
        return _entries;
    }
}