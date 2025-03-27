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
            var fullName = "Abid Bin Ahosan ";
            // Trim method removes the white spaces from the beginning and the end of the string
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            // ToUpper method converts the string to uppercase
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            // ToLower method converts the string to lowercase
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());

            // IndexOf method returns the index of the first occurrence of the specified character
            var index = fullName.IndexOf(' ');
            // Substring method returns a new string that is a substring of this string
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // Another way to get the first name
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[2]);
            Console.WriteLine("Names after spliting and storing in the array of string");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }   
            // Replacing the string of the name from the string
            Console.WriteLine(fullName.Replace("Abid", "AKA SYPBIT"));

            // Checking the string is null or empty
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid for NULL!");
            }
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid for Empty!");
            }
            // Checking the string is null or white space
            if ( String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid for White Spcae!");
            }

            // Convert string to number
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age + 1);

            // Convert number to string
            float number = 29.95f;
            Console.WriteLine(number.ToString("C")); // Currency
            Console.WriteLine(number.ToString("C0")); // Currency without decimal
            Console.WriteLine(number.ToString("C3")); // Currency with 3 decimal places
        }
    }
}
