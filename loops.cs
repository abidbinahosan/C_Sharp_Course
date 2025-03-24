using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops
            //for loop
            int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8};
            string[] names = new string[3] { "Abid", "Bin", "Ahosan" };
            string fullName = "Abid Bin Ahosan";

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //while loop
            var j = 0;
            while (j < names.Length)
            {
                Console.WriteLine(names[j]);
                j++;
            }

            // foreach loop
            foreach (var character in fullName)
            {
                Console.WriteLine(character);
            }
        }
    }
}
