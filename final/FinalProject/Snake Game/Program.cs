using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Snake Game");
        Console.WriteLine("1. StartGame");
        Console.WriteLine("2. Quit");
        int option = int.Parse(Console.ReadLine());


        if (option == 1)
        {
            Console.Clear();
            GameManager _manager = new();

            _manager.StartLoop();

        }
        else
        {


        }
        
        
    }
}