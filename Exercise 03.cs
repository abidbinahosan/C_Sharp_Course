using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Excersice 02
 Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console. */
namespace C_Sharp_Course
{
    internal class Program
    {
        private static readonly object random;

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            const int totalNumbers = 5;
            Console.WriteLine("Enter " + totalNumbers + " unique numbers:");

            while (numbers.Count < totalNumbers)
            {
                Console.Write($"Enter number {numbers.Count + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number)) 
                {
                    if (numbers.Contains(number)) 
                    {
                        Console.WriteLine("Error: Number already entered. Please enter a unique number.");
                    }
                    else
                    {
                        numbers.Add(number); 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }
            }

            numbers.Sort(); 

            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
        }
    }
}
