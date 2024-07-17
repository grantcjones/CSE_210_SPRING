using static System.Console;

public class Entry {
    private string _input;
    private string _date;
    private int _emotionalLevel;
    private Prompt _prompt;

    public Entry(string input, string date, int emotionalLevel, Prompt prompt) {
        _input = input;
        _date = date;
        _emotionalLevel = emotionalLevel;
        _prompt = prompt;
    }

    public void DisplayEntry() {
        WriteLine($"{_date}\n{_prompt.GetPrompt()}\n{_input}\nEmotional Level: {_emotionalLevel}");
    }

    public string GetEntry() {
        return $"{_date}\n{_prompt.GetPrompt()}\n{_emotionalLevel}\n{_input}\n";
    }

}