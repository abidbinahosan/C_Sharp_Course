using System;
using System.Collections.Generic;
using System.IO;
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
            // Write a program that reads a text file and displays the number of words
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                int wordCount = File.ReadAllText(filePath).Split(' ', '\n', '\r', '\t', (char)StringSplitOptions.RemoveEmptyEntries).Length;
                Console.WriteLine($"Number of words: {wordCount}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
