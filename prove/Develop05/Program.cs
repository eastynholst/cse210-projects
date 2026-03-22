using System;
using System.Buffers;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        Console.WriteLine("Welcome to Quest system");

        bool running = true;
        while(running)
        {
            Console.WriteLine($"\nYou have { manager.Score} points.");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do:  ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                manager.CreateGoal(); 
            }
            else if (choice == "2")
            {
                manager.ListGoals(); 
            }
            else if (choice == "3")
            {
                manager.SaveGoals(); 
            }
            else if (choice == "4")
            {
                manager.LoadGoals(); 
            }
            else if (choice == "5")
            {
                manager.RecordEvent(); 
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Nope wrong choose a right choose");
            }

        }
    }
}
