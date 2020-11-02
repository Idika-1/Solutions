using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Program
    {
        //Program that displays the characters and frequency of characters from a given string
        static void Main(string[] args)
        {
            Console.WriteLine("Solution to Number 1\n");
            Console.Write("Please enter a string: ");
            var stringEntered = Console.ReadLine();
            Console.WriteLine(" ");

            //Using if statement to catch empty strings or white spaces
            if (string.IsNullOrWhiteSpace(stringEntered))
            {
                Console.WriteLine("Error! String cannot be empty. Please enter a string");
            }

            //Using Method LINQ syntax to group the characters in the string
            var stringList = stringEntered.GroupBy(a => a).ToList();

            //Using foreach loop to iterate over the list and display the characters and their frequency
            foreach (var s in stringList)
            {
                //Using string interpolation to output the result
                Console.WriteLine($"Character {s.Key} occurs {s.Count()} times");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please press any key to exit!");
            Console.ReadKey();
        }
    }
}
