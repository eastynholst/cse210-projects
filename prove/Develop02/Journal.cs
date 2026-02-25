using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>
    {
        
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made you smile today?",
        "What are you grateful for right now?"

    };

    public Random _random = new Random();

/// <summary>
/// Stores the data of what the user put into the journal
/// </summary>
    public void AddNewEntry ()
    {
        string date = DateTime.Now.ToShortDateString();
        int index = _random.Next (_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($" Prompt: {prompt} ");
        Console.Write(" Your response:   ");
        string response = Console.ReadLine() ?? "";

    
        Entry newEntry = new Entry(date, prompt, response);

       
        _entries.Add(newEntry);

        Console.WriteLine("Entry saved! ");
    }
    
    /// <summary>
    /// Displays the outputs of the entries
    /// </summary>
    public void display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine(" The journal is  empty. ");
            return;
        }

        Console.WriteLine(" Journal Entries ");
       
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayString());
            
        }

    }

}