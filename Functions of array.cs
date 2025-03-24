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
            int[] numbers = new int[] { 4, 5, 2, 3, 1};
            int[] numbers2 = numbers;

            //Length
            Console.WriteLine(numbers.Length);

            //IndexOf
            Console.WriteLine(Array.IndexOf(numbers, 1));

            //Copy
            Array.Copy(numbers, numbers2, numbers2.Length);
            foreach (int i in numbers) Console.WriteLine(i);
            Console.WriteLine();

            //Sort
            Array.Sort(numbers);
            foreach (int i in numbers) Console.WriteLine(i);
            Console.WriteLine();

            //Reverse
            Array.Reverse(numbers);
            foreach (int i in numbers) Console.WriteLine(i);
            Console.WriteLine();

            //Clear
            Array.Clear(numbers2, 0, numbers2.Length);
            foreach (int i in numbers2) Console.WriteLine(i);
            Console.WriteLine();
        }
    }
}
