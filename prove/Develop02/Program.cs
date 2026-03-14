using System;

class Program
{
    /// <summary>
    /// This is the main menu of the program if statment
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to Your journal");

        while(true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a new journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
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
            else if (choice == "3")
            {
                journal.loadFromFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
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