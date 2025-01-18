using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNumber = 999999999;

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");

            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
            numbers.Add(inputNumber);
            }

        }

        //Calculate the sum

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        //Calculate the Largest Number

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        //Calculate the Average

        int count = 0;

        foreach (int number in numbers)
        {
            count = count + 1;
        }

        int avg = sum/count;

        //Display Results

        Console.Write($"The sum is: {sum} ");

        Console.Write($"The average {avg} ");

        Console.Write($"The largest number is: {maxNumber}");
    }
}