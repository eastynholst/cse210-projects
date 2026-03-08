using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking you through breathing in and out slowly. " +
               "Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Hold");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Now Breathe out..");
            ShowCountdown(6);
            Console.WriteLine();
            Console.WriteLine("\nGreat job breathing with intention.");
        }
        EndActivity();
    }
}