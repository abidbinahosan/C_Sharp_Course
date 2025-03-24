using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    internal class Program
    {
        public static object Converted { get; private set; }

        static void Main(string[] args)
        {
            // Convert string to number in any type
            string number = "1234";
            int num = int.Parse(number);

            Console.WriteLine(num + 1);

        }
    }
}
