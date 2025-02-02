using System;

class Program
{
    static public int _option;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        MenuLoop();  // Start the menu loop
    }


    static public void MenuLoop()
    {
        Journal journal = new Journal();  // Create a Journal object once outside the loop so that it can be used
        
        do
        {
            _option = DisplayMenu();  // Display the menu

            Entry newEntry = new Entry(); // Create a new entry object for each added on entry
            newEntry._dateTime = DateTime.Now;

            
            switch (_option)
            {
                case 1: // 1. Write
                    // Get the prompt for the new entry
                    newEntry._randomPrompt = newEntry.GetPrompt();
                    // Gets what the user inputted for the prompt
                    newEntry._userData = newEntry.GetUserData();

                    // Adds the entry to the entry list
                    journal.AddEntry(newEntry);

                    break;

                case 2: // 2. Display
                    // Display journal entries
                    foreach (Entry entry in journal._entryList)  
                    {
                        Console.WriteLine("");
                        Console.WriteLine(entry.DisplayEntry());
                        Console.WriteLine("");
                    }
                    break;

                case 3: // 3. Load
                        
                        Console.WriteLine("What is the filename?"); // Asks the user for the filename
                        journal._filename = Console.ReadLine(); // Stores the filename into the _filename attribute
                        journal.LoadEntries(journal._filename); // loads the entries from the file into the 
                    break;

                case 4: // 4. Save

                        Console.WriteLine("What is the filename?"); // Asks the user for the filename
                        journal._filename = Console.ReadLine(); // Stores the filename into the _filename attribute
                        journal.SaveEntries(journal._filename); // Saves the entries from the list and updates the file with the new set of entries
                        
                
                    break;

                case 5: // 5. Quit
                    //breaks loop and ends the program
                    
                    break;
            }
        } while (_option != 5);  
    }

    static public int DisplayMenu() // Method for displaying the menu text
    {
        int _option; // initializes the option 
        do  // do loop to make sure the menu appears at least once
        {   Console.WriteLine("Please Select one of the following choices"); 
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            _option = int.Parse(Console.ReadLine()); // Stores the option the user picked into the _option attribute and converts it to an integer

        } while (_option < 1 || _option > 5); //Ensures the menu is displayed even if they enter the wrong number
    
        return _option; //returns what option was displayed so that it can be used elsewhere
    }
}

