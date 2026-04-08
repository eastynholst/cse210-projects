using System;

public class Character
{
    private int _currentHealth;
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; } = 1;
    public int MaxHealth { get; private set; }
    public int CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = Math.Clamp(value, 0, MaxHealth);
    }
    public int SpellSlots { get; set; } = 0;
    public List<string> skills {get; private set; } = new();
    public List<string> Inventory {get; private set; } = new();

    public Character (string name, string characterClass, int maxHealth = 25)
    {
        Name = name;
        Class = characterClass;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;

        string lowerClss = characterClass.ToLower();
        if(lowerClss.Contains("wizard")||lowerClss.Contains("sorcerer")||lowerClss.Contains("cleric")||lowerClss.Contains("druid"))
        {
            SpellSlots = 3;
        }
    }

    public void AddSkill(string skill)
    {
        skills.Add(skill);
    }

    public void AddItem(string  item)
    {
        Inventory.Add(item);
    }
    
    public virtual void DisplaySheet()
    {
        Console.Clear();
        Console.WriteLine($"{Name.ToUpper()}");
        Console.WriteLine($"Class : {Class}");
        Console.WriteLine($"Level : {Level}");
        Console.WriteLine($"Health : {CurrentHealth} / {MaxHealth}");
        if (SpellSlots > 0 )
            Console.WriteLine($"Spell slots : {SpellSlots}");
        
        Console.WriteLine("\n Skills ");
        if (skills.Count == 0)
            Console.WriteLine(" No skills added yet. ");
        
        else
        {
            foreach (var skill in skills)
            Console.WriteLine($" {skills}");
        }
        
        Console.WriteLine(" Backpack ");
        if (Inventory.Count == 0)
            Console.WriteLine(" Empty ");
        
        else
        {
            foreach (var item in Inventory)
                Console.WriteLine($" {item} ");
        }
        Console.WriteLine("------------------------------");

    }
}