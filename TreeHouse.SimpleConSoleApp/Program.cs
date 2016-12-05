using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouse.SimpleConSoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            string greeting = "Hello World~";

            string name = "Weaver YXL";

            Console.Write(greeting + " ");
            string[] a = SplitName(name);
            Console.WriteLine(a[1]);
        }

        static string[] SplitName(string name)
        {
            return name.Split(' ');
            
        }
    }
}
