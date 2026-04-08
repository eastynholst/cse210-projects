using System.Transactions;

public class BattleMode
{
    private Character currentCharacter;
    private DiceRoller diceRoller;
    public BattleMode(Character character, DiceRoller dice)
    {
        currentCharacter = character;
        diceRoller = dice;
    }
    public void SetCharacter(Character character)
    {
        currentCharacter = character;
    }
    public void Start()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine(" Battle Mode ");
            Console.WriteLine("1. Dice Roller ");
            Console.WriteLine("2. Health Change ");
            Console.WriteLine("2. View Skills ");
            Console.WriteLine("3. Back ");
            Console.Write("Choice: ");
            string Choice = Console.ReadLine();

            if (Choice == "1")
            {
                diceRoller.StartDiceMenu();
            }

            else if (Choice == "2")
            {
                HealthChange();
            }
            else if (Choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Current Skills ");
                foreach (var skill in currentCharacter.skills)
                   Console.WriteLine($" {skill} ");
            }
            else if (Choice == "4")
            {
                return;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
    public void HealthChange()
    {
        Console.Clear();
        Console.WriteLine($"Current Health: {currentCharacter.CurrentHealth} / {currentCharacter.MaxHealth}");
        Console.Write("Health Change (+heal, -damage)");

        if(int.TryParse(Console.ReadLine(), out int amount))
        {
            currentCharacter.CurrentHealth += amount;
            Console.WriteLine($"Health changed by {amount} NEw Health {currentCharacter.CurrentHealth}");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}