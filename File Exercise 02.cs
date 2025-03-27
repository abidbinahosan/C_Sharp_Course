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
            // Write a program that reads a text file and displays the longest word in the file.
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string longestWord = File.ReadAllText(filePath)
                .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(w => w.Length)
                .FirstOrDefault();

            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}
