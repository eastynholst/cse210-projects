using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 100);
    
    int guess = 0;
    
    while (guess != number)
        {
            Console.Write("what is your guess ");
            guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("Lower" );
            }
            if(guess < number)
            {
                Console.WriteLine("Higher" );
            }
            if(guess == number)
            {
                Console.WriteLine("You guesed the magic number " );
            }
        }
    }
}