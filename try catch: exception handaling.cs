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
            // Exception handaling 
            try
            {
                var number = "1234";
                byte way_one = Convert.ToByte(number);
                Console.WriteLine(way_one);
            }
            catch(Exception)
            {
                Console.WriteLine("This can't be converted due to over flow!");
            }
        }
    }
}
