using System;

public class SkillsMode
{
    private Character currentCharacter;
    public SkillsMode (Character character)
    {
        currentCharacter = character;
    }
    public void SetCharacter(Character character)
    {
        currentCharacter = character;
    }
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Skills & Backpack ");
            currentCharacter.DisplaySheet();

            Console.WriteLine("1. Add New Skill ");
            Console.WriteLine("2. Add New Item to Backpack ");
            Console.WriteLine("3. Back ");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Skill:");
                string skill = Console.ReadLine();
                currentCharacter.AddSkill(skill);
            }
            else if (choice == "2")
            {
                Console.Write("Item ");
                string item = Console.ReadLine();
                currentCharacter.AddItem(item);
            }
            else
            {
                return;
            }
        }
    }
}