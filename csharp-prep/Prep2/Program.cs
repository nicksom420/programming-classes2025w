using System;

class Program
{
    static void Main(string[] args)
    {
        
        string grade = "";//Define the grade variable so that it can be used later

        Console.Write("What is your grade percentage in the class? ");//Ask the user his percentage
        string gradePercentage = Console.ReadLine();//stores his grade into a variable

        int x = int.Parse(gradePercentage);//converts his string response into an integer

        if (x >= 90)// Compares his percentage to grading standards
        {
            grade = "A";
        }
        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }
        else if (x >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your letter grade is {grade}");//Displays his letter grade
    }
}