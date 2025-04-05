using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Snake Game");
        Console.WriteLine("The snakes head is represented as @ and the body as O and the fruit as $.");
        Console.WriteLine("The goal is to get the longest snake as possile good luck ^_^");
        Console.WriteLine("There is some input delay for the snakes direction changes but you'll get used to it");
        Console.WriteLine("");
        Console.WriteLine("1. StartGame");
        Console.WriteLine("2. Quit");
        int option = int.Parse(Console.ReadLine());


        if (option == 1)
        {
            Console.Clear();
            GameManager _manager = new();

            _manager.StartLoop();

            Console.Clear();
            Console.SetCursorPosition(15,8);
            Console.Write("Thanks for playing! ^_^");
            Thread.Sleep(1000);
            Console.Clear();

        }
        else
        {
            Console.Clear();

        }
        
        
    }
}