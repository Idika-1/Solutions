using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    //Program that checks whether an alphabet is a vowel or consonant.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution to Number 4\n");
            //Creating a list of alphabets
            var alphabets = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            //Creating a list of Vowels
            var vowels = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };

            Console.Write("Enter a single character: ");
            var characterEntered = (Convert.ToChar(Console.ReadLine()));

            Console.WriteLine(" ");
            
            //Converting the input to lower case
            var characterLower = char.ToLower(characterEntered);

            //Checking for white or empty spaces
           
            if (!alphabets.Contains(characterLower))
            {
                Console.WriteLine("Error! Your input is not an English alphabet\n");
            }
            else if (vowels.Contains(characterLower))
            {
                Console.WriteLine($"The alphabet is a vowel\n");
            }
            else
            {
                Console.WriteLine($"The alphabet is a consonant\n");
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
