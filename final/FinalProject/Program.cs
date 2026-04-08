using System;
   class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the DnD Helper");
            Console.WriteLine($"\nAre you a Gungeon Master or a Player?");
            Console.WriteLine("1. Dungeon Master");
            Console.WriteLine("2. Player");
            Console.Write("Choice: ");
        
            string role = Console.ReadLine();
            Console.WriteLine();

            if (role == "1")
            {
                DMMenu dm = new DMMenu();
                dm.start();
            }
            else if (role == "2")
            {
                PlayerMenu player = new PlayerMenu();
                player.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadKey(true);
            }
        }
    }
}