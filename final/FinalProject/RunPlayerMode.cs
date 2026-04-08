public class PlayerMenu
{
    private Character currentCharacter = default!;
    private DiceRoller diceRoller = new DiceRoller();

    private SkillsMode skillsMode;
    private RestMode restMode;
    private BattleMode battleMode;

    public PlayerMenu()
    {
        skillsMode = new SkillsMode(null);
        restMode = new RestMode(null);
        battleMode = new BattleMode(null, diceRoller);
    }
    public void Start()
    {
        while (true)
        {
            Console.Clear();

            if (currentCharacter == null)
            {
                Console.WriteLine(" PLayer Mode ");
                Console.WriteLine("1. Create New Character");
                Console.WriteLine("2. Back to Main Menu");
            }
            else
            {
                currentCharacter.DisplaySheet();

                Console.WriteLine("Player Actions: ");
                Console.WriteLine("1. Skills / Backpack");
                Console.WriteLine("2. Rest / Sleep ");
                Console.WriteLine("3. Battle ");
                Console.WriteLine("4. Heal change ");
                Console.WriteLine("5. Dice ROller");
                Console.WriteLine("6. Back to main menu");
            }
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            
            if (currentCharacter == null)
            {
                if (choice == "1") CreateNewCharacter();
                else if (choice == "2") return;
            }
            else
            {
                skillsMode.SetCharacter(currentCharacter);
                restMode.SetCharacter(currentCharacter);
                battleMode.SetCharacter(currentCharacter);

                if (choice == "1")
                    skillsMode?.Start();
                else if (choice == "2")
                    restMode?.Start();
                else if (choice == "3")
                    battleMode?.Start();
                else if (choice == "5")
                    diceRoller.StartDiceMenu();
                else if (choice == "4")
                    HealthChange();
                else if (choice == "6")
                    return;
                else
                    Console.WriteLine("ERROR");
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }    
    private void CreateNewCharacter()
    {
        Console.Clear();
        Console.WriteLine("Create New Character");
        Console.Write("Enter character's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter character's class (Warrior, Wizard, Rogue, Cleric, etc.");
        string characterClass = Console.ReadLine();

        Console.WriteLine("\nHow do you want to set Max Health?");
        Console.WriteLine("1. Choose a nunmber ");
        Console.WriteLine("2. Roll randomly (10-30)");
        Console.Write("Choice (1 or 2): ");
        string healthChoice = Console.ReadLine();

        int maxHealth = 25;
        if (healthChoice == "2")
    {
        maxHealth = new Random().Next(10,31);
        Console.WriteLine($"Rolled: {maxHealth}");
    }
    else
    {
        Console.Write("Please enter Health: ");
        int.TryParse(Console.ReadLine(), out maxHealth);
    }

    currentCharacter = new Character(name, characterClass, maxHealth);
    }
    public void HealthChange()
    {
        Console.Clear();
        Console.WriteLine($"Current Health: {currentCharacter.CurrentHealth} / {currentCharacter.MaxHealth}");
        Console.Write("Health Change (+heal, -damage)");

        if(int.TryParse(Console.ReadLine(), out int amount))
        {
            currentCharacter.CurrentHealth += amount;
            Console.WriteLine($"Health changed by {amount} New Health {currentCharacter.CurrentHealth}");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

