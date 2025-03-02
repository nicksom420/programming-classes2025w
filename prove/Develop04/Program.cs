using System;

class Program
{
    static void Main(string[] args)
    {
        int option;  // Only declare option inside Main

        do
        {
            option = DisplayMenu();  // Display the menu and get user input

            switch (option)
            {
                case 1: // 1. Breathing
                    Console.Clear();
                    BreathingActivity myBreath = new("Breathing Activity", 
                        "This activity will guide you through a relaxing breathing activity where you breathe in and out at certain intervals to help calm and relax the soul", 
                        30);
                    myBreath.ActivityOutline(myBreath);
                    break;

                case 2: // 2. Reflecting
                    Console.Clear();
                    ReflectActivity myReflect = new("Reflecting Activity", 
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                        30);
                    myReflect.ActivityOutline(myReflect);
                    break;

                case 3: // 3. Listing
                    Console.Clear();
                    ListingActivity myLister = new("Listing Activity", 
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
                        30);
                    myLister.ActivityOutline(myLister);
                    break;

                case 4: // 4. Quit
                    Console.WriteLine("Exiting program...");
                    break;
            }
        } while (option != 4);  
    }

    static int DisplayMenu() // Method for displaying the menu text
    {
        int option; // Local variable for menu choice

        do
        {
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine(); // Read user input
            if (!int.TryParse(input, out option) || option < 1 || option > 4)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }

        } while (option < 1 || option > 4); // Ensures valid input
        
        return option; // Returns the user's valid choice
    }
}

    