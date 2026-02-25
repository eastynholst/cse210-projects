using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        
        List<int> numbers = new List<int>();
        int input = -1;
        while (input != 0 )
        {
            Console.Write("Enter number (input 0 to stop) ");
            string userinput = Console.ReadLine(); 
            input = int.Parse(userinput);
            
            if(input != 0)
            {
                numbers.Add(input);
            }      
        }
        int sum = 0;
        foreach (int number in numbers)

        {
        sum += number;
        }
        Console.WriteLine($"Your sum is {sum}");
            
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];
            
        foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine($"the max is : {max}");
        
         

    }
}