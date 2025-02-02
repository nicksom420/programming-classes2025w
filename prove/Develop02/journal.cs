using System;

public class Journal
{

    public List<Entry> _entryList = new List<Entry>(); // initializes the entry list
    
    public string _filename; // creates _filename attribute so that it can be used


    public void AddEntry(Entry entry) // Method for adding entry to list
    {

        _entryList.Add(entry);    
    }

    
    public void SaveEntries(string _filename) // Method to save journal entries into the file
    {
        using (StreamWriter writer = new StreamWriter(_filename)) // if the file does not exists makes a new one
        {
            foreach (Entry entry in _entryList) // iterates through each entry in the list
            {
                writer.WriteLine(entry.CompileEntry()); // puts compiled entry into the file
                writer.WriteLine(); // Add an empty line to separate each entry in the file
            }
        }
        
    }

        public void LoadEntries(string _filename) // Method to load the entries from a file
    {
        if (File.Exists(_filename)) // Check if the file exists
        {
            _entryList.Clear(); // Clear current list so that a new one can be loaded from the file
            
            Entry newEntry = null; // Initialize a new object to hold the entry data
            
            
            foreach (string line in File.ReadLines(_filename)) // read the lines from the file
            {
                if (line.StartsWith("Date:")) // Finds out if the line starts with "Date:" signifying an entry
                {
                    newEntry = new Entry(); // Create a new Entry instance to update with entry information

                    string[] parts = line.Split(" - Prompt: "); // Split the string into two parts the date and the prompt. (splits and saves everything before " - Prompt:" as parts[0] and everything after as parts [1])
                    newEntry._dateTime = DateTime.Parse(parts[0].Replace("Date: ", "")); // Gets rid of the text "Date: " and only saves the date so it can be stored as _dateTime
                    newEntry._randomPrompt = parts[1]; // stores the prompt as the prompt in the string
                }
                else if (!string.IsNullOrWhiteSpace(line) && newEntry != null) // Checks if they inputted an entry and checks if it has a date and prompt attatched to it
                {
                    newEntry._userData = line; // adds the user input and stores to to be compiled into the list.
                    _entryList.Add(newEntry); // Add the entry to the list
                    newEntry = null; // Reset the temporary entry for the next journal entry
                }
            }

        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

}