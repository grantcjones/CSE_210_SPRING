using System;
using System.Runtime.CompilerServices;
using static System.Console;

public class Word {
    private string _wordText { get; set; }
    private bool _isHidden { get; set; }

    public Word(string word) {
        _wordText = word;
        _isHidden = false;
    }

    public bool IsHiddenTrue() {
        if (_isHidden) {
            return true;
        }
        else {
            return false;
        }
    }

    public void Hide() {
        _isHidden = true;
    }

    public string GetWord(Word item) {
        if (_isHidden) {
            return new string('_', _wordText.Length);
        }
        else {
            return item._wordText;
        }
    }


}