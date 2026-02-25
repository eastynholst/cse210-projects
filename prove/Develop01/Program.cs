using System;

private class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to Your journal");

        while(true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a new journal");
            Console.WriteLine("3. Quit");
            Console.Write("What would you like to do  ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                journal.AddNewEntry();
            }
            else if (choice == "2")
            {
                journal.display();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thanks for writing today. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Nope wrong choose a right choose");
            }

        }
    }
}