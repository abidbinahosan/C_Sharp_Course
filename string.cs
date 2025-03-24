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
            //Normally this type of string can ignore some character
            string name = "https:\\:baihdjdh:\\abid";
            Console.WriteLine(name);

            //To avoid this we can add a '@' sign in front of the string
            name = @"https:\\:baihdjdh:\\abidgd";
            Console.WriteLine(name);
        }
    }
}
