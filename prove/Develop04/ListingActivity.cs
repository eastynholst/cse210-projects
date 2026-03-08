using System;
using System.ComponentModel;
using System.Reflection.Metadata;
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
       private Random _random = new Random();
    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompts:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
    
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("\nGo! \n");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string response = Console.ReadLine();
            items.Add(response);
        }
        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
        
    }
}