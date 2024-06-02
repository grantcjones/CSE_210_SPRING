using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static System.Console;
using static System.Random;

public class Scripture {
    // private string v1;
    // private string v2;

    private List<Word> _words { get; set; }
    private Reference _reference { get; set; }

    // Constructors
    public Scripture(string words, Reference reference) {
        _words = new List<Word>();
        List<string> convert = new List<string>(words.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        foreach (string i in convert) {
            Word newWord = new Word(i);
            _words.Add(newWord);
        }

        _reference = reference;
    }

    public string GetWordsAsString() {
        List<string> wordTexts = new List<string>();
        foreach (var word in _words) {
            wordTexts.Add(word.GetWord(word));
        }
        return string.Join(" ", wordTexts);
    }

    public bool IfAllHidden() {
        int count = 0;
        foreach (Word word in _words) {
            if (word.IsHiddenTrue()) {
                count ++;
            }
        }

        if (count == _words.Count()) {
            return true;
        }
        else {
            return false;
        }
    }


    public void HideWords() {
        int wordsToHide = 3;
        int maxListLength = _words.Count;

        if (IfAllHidden()) {
            return;
        }

        List<int> nonHiddenIndices = new List<int>();
        for (int i = 0; i < maxListLength; i++) {
            if (!_words[i].IsHiddenTrue()) {
                nonHiddenIndices.Add(i);
            }
        }

        if (nonHiddenIndices.Count < wordsToHide) {
            wordsToHide = nonHiddenIndices.Count;
        }

        Random random = new Random();
        for (int i = 0; i < wordsToHide; i++) {
            int randomIndex = random.Next(nonHiddenIndices.Count);
            int wordIndex = nonHiddenIndices[randomIndex];
            _words[wordIndex].Hide();
            nonHiddenIndices.RemoveAt(randomIndex);
        }
    }

    public string Display() {
        return $"{_reference.GetReference()} {GetWordsAsString()}";
    }
}
    