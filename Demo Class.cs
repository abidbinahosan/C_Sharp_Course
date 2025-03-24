using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;

        public void Intro()
        {
            Console.WriteLine("Hi! My name is " + FirstName + " " + MiddleName + " " + LastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Abid = new Person();
            Abid.FirstName = "Abid";
            Abid.MiddleName = "Bin";
            Abid.LastName = "Ahosan";

            Abid.Intro();
        }
    }
}
