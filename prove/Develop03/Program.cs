using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture();

        while(true)
        {
            Console.Clear();

            Console.WriteLine($"{reference.GetDisplayText()}   {scripture.GetDisplayText()}");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to hide 4 more words");
            Console.WriteLine("or type quit to stop");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
            int remaining = scripture.HideSomeWords();
            if (remaining == 0 )
            {
                break;
            }
            
            scripture.HideSomeWords();
        }
    }
}
