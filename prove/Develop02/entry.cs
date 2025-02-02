using System;

public class Entry
{
    public DateTime _dateTime; // The Date and Time
    public string _userData; // What the user Inputted
    public string _randomPrompt; // Where the prompt is stored


    public List<string> _prompts = new List<string>() // The Prompts that can be used
    {
        "How was the weather today?",
        "Did you workout today? If so, what did you hit?",
        "What people did you interact with today?",
        "What food did you eat today?"
    };


    public string GetPrompt() // Method to get the randomized prompt
    {
        Random random = new Random(); // Creates a random object
        int index = random.Next(_prompts.Count); // Iterates through prompt list and selects a random one
        return _prompts[index]; // Returns the randomly selected prompt
    }
        
    
    public string GetUserData() // Method to store the user input
    {
        Console.Write($"{_randomPrompt}\n> "); // Shows the user what question to answer
        _userData = Console.ReadLine(); // stores the user input into an attribute
        return _userData; // returns the input
    }

  
    public string CompileEntry() // Method to compile the journal entry
    {
        return $"Date: {_dateTime.ToString("MM/dd/yyyy")} - Prompt: {_randomPrompt} \n{_userData}"; // Properly Formatted entry
    }

    public string DisplayEntry() // Method to display the journal entry to the use
    {
        return CompileEntry(); // Calls compile entry method
    }
}
