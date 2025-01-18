using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int numberSquared = SquareNumber(number);

        DisplayResult(numberSquared, number, name);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber( int number)
    {
        int squaredNumber = number*number;

        return squaredNumber;

    }

    static void DisplayResult(int squaredNumber, int number, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        
    }
}   
