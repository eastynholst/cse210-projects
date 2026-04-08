using System;

public class RestMode
{
    private Character currentCharacter;
    public RestMode(Character character)
        {
            currentCharacter = character;
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
            Console.WriteLine(" Rest / Sleep ");
            Console.WriteLine("1. Half Rest (Heals health half) ");
            Console.WriteLine("2. Full Rest (full Health + return spell slots) ");
            Console.WriteLine("3. Back ");
            Console.Write("Choice: ");
            string Choice = Console.ReadLine();

            if (Choice == "1")
            {
                int healamount = currentCharacter.MaxHealth / 2;
                currentCharacter.CurrentHealth += healamount;
                Console.WriteLine($"Half rest: +{healamount} health ");
            }

            else if (Choice == "2")
            {
                currentCharacter.CurrentHealth = currentCharacter.MaxHealth;
                if (currentCharacter.SpellSlots > 0) 
                    currentCharacter.SpellSlots = 3;
                Console.WriteLine("Full rest complete");
            }
            else if (Choice == "3")
            {
                return;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
