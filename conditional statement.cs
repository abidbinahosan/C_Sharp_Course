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
            int hour = 10;
            if (hour > 0 && hour < 12) { 
                Console.WriteLine("It's morning!");
            }
            else {
                Console.WriteLine("It's evening");
            }
        }
    }
}
