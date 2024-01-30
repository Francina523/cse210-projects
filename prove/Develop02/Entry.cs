public class Entry
{
public string _date;
public string _promptText; 
public string _entryText;

public Entry(string date, string promptText, string entryText)
    {
        _date = date ?? (nameof(date));
        _promptText = promptText ?? (nameof(promptText));
        _entryText = entryText ?? (nameof(entryText));
    }

public void Display()
{
    Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}\n");

}
public override string ToString()
    {
        return $"{_date},{_promptText},{_entryText}";
    }
}