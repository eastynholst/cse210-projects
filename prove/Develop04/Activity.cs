using System;
public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }
    protected void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    
    protected void ShowSpinner(int seconds)
    {
        
        DateTime endtime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endtime)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b \b \b");

            Console.Write("--");
            Thread.Sleep(300);
            Console.Write("\b \b \b \b");
            
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b \b \b");
            
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b \b \b");

        }   
    }
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i,2}");
            Thread.Sleep(1000);
        }
    }
    public abstract void Run();
}