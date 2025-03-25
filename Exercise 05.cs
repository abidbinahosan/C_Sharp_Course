using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Excersice 05
Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.*/
namespace C_Sharp_Course
{
    internal class Program
    {
        private static readonly object random;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter at least 5 comma-separated numbers: ");
                string input = Console.ReadLine();

                string[] parts = input.Split(',');
                List<int> numbers = new List<int>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        numbers.Add(number);
                    }
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue;
                }

                numbers.Sort();
                Console.WriteLine("The 3 smallest numbers are: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
                break;
            }
        }
    }
}
