using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        while(true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do:  ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                breathing.Run();
            }
            else if (choice == "2")
            {
                reflection.Run();
            }
            else if (choice == "3")
            {
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you fro using the midfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Nope wrong choose a right choose");
            }

        }
    }
}