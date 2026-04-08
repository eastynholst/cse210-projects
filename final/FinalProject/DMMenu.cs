using System;

public class DMMenu
{
    private DiceRoller diiceRoller = new DiceRoller();

    public void start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" DM Mode ");
            Console.WriteLine("1. Dice Roller ");
            Console.WriteLine("2. Quick Battle Tracker");
            Console.WriteLine("3. Back to Main Menu ");
            Console.Write("Choice: ");
            
            string choice = Console.ReadLine();
            if (choice == "1")
                diiceRoller.StartDiceMenu();
            else if (choice == "2")
                QuickBattleTracker();
            else if (choice == "3")
                return;
            else
                Console.WriteLine("Error - Please press any key to return");
                Console.ReadKey (true);
        }
    }
        
    private void QuickBattleTracker()
    {
        Console.Clear();
        Console.WriteLine(" Quick Battle Tracker");
        Console.Write("Character Name: ");
        string name = Console.ReadLine();

        Console.Write($"Current health for {name}: ");
        if (int.TryParse(Console.ReadLine(), out int health))
        {
            Console.WriteLine($"Tracking {name} and HP {health}");
        }
    }
}