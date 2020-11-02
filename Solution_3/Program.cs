using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class Program
    {
        //Program that exchanges the first and last characters in a given string and returns the new string.
        static void Main(string[] args)
        {
            Console.WriteLine("Solution to Number 3\n");
            Console.Write("Please enter a string: ");
            var stringEntered = Console.ReadLine();
            Console.WriteLine(" ");

            //Using if-else statement to handle empty strings or whitespaces and strings with less than two characters
            if (string.IsNullOrWhiteSpace(stringEntered))
            {
                Console.WriteLine("Error!!! String cannot be empty or contain white spaces\n");
            }
            else if (stringEntered.Length < 2)
            {
                Console.WriteLine(stringEntered + "\n");
            }
            else
            {
                var firstChar = stringEntered.First();
                var lastChar = stringEntered.Last();

                //Creating a temporal variable to be used in switching the values of the first and last characters
                var tempChar = lastChar;

                //Swapping the values:
                lastChar = firstChar;
                firstChar = tempChar;

                //Obtaining the string of middle characters
                var middleChars = stringEntered.Substring(1, stringEntered.Length - 2);

                //Output the result:
                Console.WriteLine($"{firstChar}{middleChars}{lastChar}\n");
            }

            Console.WriteLine("Kindly press any key to exit!");
            Console.ReadKey();
        }
    }
}
