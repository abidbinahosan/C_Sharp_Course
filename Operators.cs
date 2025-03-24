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
            // Operators
            // Arithmetic Operator
            int a = 30, b = 7;
            Console.WriteLine($"Sum = { a + b}");
            Console.WriteLine($"Sub = { a - b}");
            Console.WriteLine($"Mul = { a * b}");
            Console.WriteLine($"Div = { a / b}");
            Console.WriteLine($"Mod = { a % b}");

            // Comparison Operator (==, !=, <, >, <=, >=)
            if (a > b) Console.WriteLine("A is greater than B");
            else if (a < b) Console.WriteLine("A is less than B");
            else if (a == b) Console.WriteLine("A is equal to B");
            else Console.WriteLine("A is not equal to B");

            // Assignment Operator (=, +=, -=, *=, /=, %=)
            a += b;
            Console.WriteLine(a);
            a -= b;
            Console.WriteLine(a);
            a *= b;
            Console.WriteLine(a);
            a /= b;
            Console.WriteLine(a);

            // Logical Operator (&&, ||, !)
            // Bitwise Operator (&, |, ^)
        }
    }
}
