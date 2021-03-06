using System;
using System.IO;

namespace Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\Samples\quotes.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            //ReadDataFromArray(dataFromFile);

            Console.WriteLine(dataFromFile[0]);
            Console.WriteLine("How many quotes would you like to print?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DisplayQuotes(dataFromFile, userInput);
        }

        private static void ReadDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }

        private static void DisplayQuotes(string[] someArray, int someNumber)
        {
            if(someNumber > someArray.Length - 1)
            {
                someNumber = someArray.Length - 1;
            }
            for(int i = 1; i <= someNumber; i++)
            {
                Console.WriteLine(someArray[i]);
            }
        }
    }
}
