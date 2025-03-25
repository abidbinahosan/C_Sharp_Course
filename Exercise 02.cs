using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Excersice 02
 Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
 */
namespace C_Sharp_Course
{
    internal class Program
    {
        private static readonly object random;

        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            string reversedName = new string(charArray);
            Console.Write(reversedName);
            Console.WriteLine();
        }
    }
}
