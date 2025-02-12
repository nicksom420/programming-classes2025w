using System.Text.Json;

class Scripture
{
    private string _fileName;
    
    public void DisplayScripture( int bookKey, int chapterKey, int verseKey)
    {

        //Make a list to hold references
        List<string> referencesList = new List<string>();
        
        referencesList.Add("Joshua 1:9");
        referencesList.Add("D&C 4:1-7");

        //Get a dictionary containing scriptures
        Dictionary<string, List<string>> scriptureDictionary = LoadScriptures(_fileName);
        
        

    
    }

        //Method for loading the scripture from a json file
        private static Dictionary<string, List<string>> LoadScriptures(string fileName)
    {   
        //Checks if the file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
            return null;
        }
        else
        {
            // reads json file into a string, then converts it into a compound dictionary with a string
            string json = File.ReadAllText(fileName);
            Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> referenceData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>>(json);



            // Turn the converted json file into a simple dictionary where there is one key for each reference [Book Chapter Verse(s)]
            Dictionary<string, List<string>> referenceDictionary =  new Dictionary<string, List<string>>();

            foreach(var book in referenceData)
            {
                foreach(var chapter in book.Value){
                    
                    foreach(var verse in chapter.Value){

                        referenceDictionary[$"{book.Key} {chapter.Key}:{verse.Key}"] = verse.Value;

                    }
                }
            }

            return referenceDictionary;
        }

         

        
    }
}