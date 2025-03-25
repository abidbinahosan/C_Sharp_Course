using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Excersice 04
Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/
namespace C_Sharp_Course
{
    internal class Program
    {
        private static readonly object random;

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); 
            Console.WriteLine("Enter numbers (type 'Quit' to exit):");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase)) 
                {
                    break;
                }

                if(int.TryParse(input, out int number)) 
                {
                    numbers.Add(number); 
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number or 'Quit' to exit.");
                }
            }

            List<int> uniqueNumbers = new List<int>();
            foreach (int num in numbers)
            {
                if (!uniqueNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }
            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
        }
    }
}
