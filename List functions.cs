using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    internal class Program
    {
        private static readonly object random;

        static void Main(string[] args)
        {
            //Initializing a list
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            // Can add new array or list to the initial list
            numbers.AddRange(new List<int> { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //Finding index
            Console.WriteLine("First index of 1 is: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1 is: " + numbers.LastIndexOf(1));

            //Number of elements
            Console.WriteLine("Number of element is: " + numbers.Count);

            //Remove a number
            numbers.Remove(1);
            Console.WriteLine("List after removing one: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // If want to remove a numbers all occurance then use a for loop and use the remove function
            // foreach loop won't work as C++ don't

            //Clear the list
            numbers.Clear();
            Console.WriteLine("Count after clear is: " + numbers.Count());

        }
    }
}
