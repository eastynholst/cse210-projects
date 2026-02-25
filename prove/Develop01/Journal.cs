using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddNewEntry()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Console.WriteLine("\n--- Quick Check-in ---");

        Console.Write("1. What emotion are you feeling most right now? ");
        string emotion = Console.ReadLine()?.Trim() ?? "not specified";

        Console.Write("2. How strong is it? (1 = very mild, 10 = overwhelming) ");
        string intensity = Console.ReadLine()?.Trim() ?? "-";

        Console.Write("3. What would help with this feeling right now? (or just press enter) ");
        string helpNeeded = Console.ReadLine()?.Trim() ?? "";

        string response = $"Emotion: {emotion}\n" +
                          $"Intensity: {intensity}/10\n" +
                          $"What would help: {helpNeeded}";

        // Using "Daily Check-in" as the "prompt" field so it displays nicely
        Entry newEntry = new Entry(date, "Daily Check-in", response);
        _entries.Add(newEntry);

        Console.WriteLine("\nSaved. Thank you for checking in with yourself.\n");
    }
    
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