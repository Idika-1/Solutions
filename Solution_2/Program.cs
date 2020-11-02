using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Solution_2
{
    class Program
    {
        //Program that displays the list of items in a given array according to the length of the string then name them in ascending order.
        static void Main(string[] args)
        {
            Console.WriteLine("Solution to Number 2\n");

            //Define the list of items
            string[] cityList = new string[9]
            {
                "Rome", "Paris", "Amsterdam",
                "Zurich", "Carlifonia", "Nairobi",
                "London", "Abu Dhabi", "New Delhi"
            };

            //Sorting the list using Method syntax LINQ
            var sortedList = cityList.OrderBy(c => c.Length).ThenBy(d => d.First()).ToList();

           //Using foreach to loop through the sorted list
            foreach(string city in sortedList)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Please enter any key to exit!");
            Console.ReadKey();
                                                         
        }
    }
}
