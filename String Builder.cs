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
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '*');
            builder.Remove(0, 10);
            builder.AppendLine();
            builder.Insert(0, new string('-', 10));
            builder.AppendLine();

            Console.WriteLine(builder);
            Console.ReadLine();
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
