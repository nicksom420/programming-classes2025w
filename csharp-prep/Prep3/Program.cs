using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        Console.WriteLine("Welcome to the number guessing game!");

        int guess = 0;

        while (guess != number)
        {
    
            Console.Write("What is your guess? ");
            
            guess = int.Parse(Console.ReadLine());

            if (guess > number){
                Console.WriteLine("Guess Lower");
            }
            else if (guess < number){
                Console.WriteLine("Guess Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
            
        }

    }
}