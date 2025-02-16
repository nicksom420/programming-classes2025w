using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string _userInput; //initializes to differentiate between pressing enter and quit

        Reference myReference = new Reference("D&C", 4, 1,2); //Create the scripture reference so that it can be built into an object
         string formattedReference = myReference.FormattedReference(); //call the format function to create proper reference

        Scripture myScripture = new Scripture(); //Create new scripture object

        Console.Write($"{formattedReference} "); //Prints the Reference before the scripture
        myScripture.DisplayScripture(); // Displays the scripture after the reference
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:"); // Directions for user input

        while (true) // Loops so that words can be hidden multiple times
        {
            _userInput = Console.ReadLine(); // initializes the user input within the loop

            
            myScripture.HideRandomWords(); // hides three words
            
            
            Console.Clear(); // clears the console so that it can be updated
            Console.Write(myReference.FormattedReference() + " "); // Formats the reference with gap after reference
            myScripture.DisplayScripture(); // Displays scripture again with hidden words
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:"); //Prints the directions again

            if (myScripture.ifAllWordsAreHidden() || _userInput == "quit" ) // If all the words are hidden then the program ends, or the user ends the program
            {
                break; //breaks loop if either condition is true
            }

        }
    }
}
    