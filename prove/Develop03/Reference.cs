using System;
using static System.Console;

public class Reference {
    private string _book { get; set; }
    private string _chpt { get; set; }
    private string _firstVerse { get; set; }
    private string _lastVerse { get; set; }

    // Constructor for only 1 verse
    public Reference(string book, string chpt, string firstVerse) {
        _book = book;
        _chpt = chpt;
        _firstVerse = firstVerse;
    }
    // Constructor for multiple verses
    public Reference(string book, string chpt, string firstVerse, string lastVerse) {
        _book = book;
        _chpt = chpt;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string GetReference() {
        if (string.IsNullOrEmpty(_lastVerse)) {
            return $"{_book} {_chpt}: {_firstVerse}";
        }
        else {
            return $"{_book} {_chpt}: {_firstVerse}-{_lastVerse}";
        }

    }


}