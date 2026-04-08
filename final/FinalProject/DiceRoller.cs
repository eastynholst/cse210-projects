public class DiceRoller
{
    private Random rng = new Random();

    public void StartDiceMenu()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Which die do you need to roll?");
            Console.WriteLine("1. d4");
            Console.WriteLine("2. d6");
            Console.WriteLine("3. d8");
            Console.WriteLine("4. d10");
            Console.WriteLine("5. d12");
            Console.WriteLine("6. d20");
            Console.WriteLine("7. Back to previous menu");
            Console.WriteLine("\nChoice: ");
            
            string input = Console.ReadLine();
            if (input == "7")
            {
                return;
            }
            int sides = input switch 
            {
                "1" => 4,
                "2" => 6,
                "3" => 8,
                "4" => 10,
                "5" => 12,
                "6" => 20,
                _ => 0
            };
            int roll = rng.Next(1, sides +1);
            
            Console.WriteLine("\nPress any key to roll again...");
            Console.ReadKey(true);
        }
        
    }
}