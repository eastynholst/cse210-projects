using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = enterUserName();
        int userNumber = enterUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        enterUserBirthYear(out birthYear);


        Result(userName, squaredNumber, birthYear);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string enterUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
       
        return name;
    }
    static int enterUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void enterUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void Result(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}
