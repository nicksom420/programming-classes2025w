using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? "); //Displays first question to user
        string firstName = Console.ReadLine(); //Takes input from user and stores it as variable "firstName"

        Console.Write("What is your last name? "); //Displayes second question to user
        string lastName = Console.ReadLine(); //Takes input from user and stores it as variable "lastName"

        Console.Write(Environment.NewLine);//Adds extra line to separate responses from results
        Console.Write($"Your name is {lastName}, {firstName} {lastName}."); //Displays both vairables into a string as specified in course instructions
    }
}