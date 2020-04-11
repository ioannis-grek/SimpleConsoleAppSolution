using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Hello, what is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0} nice to meet you.", name);
            Console.ReadKey();
        }
    }
}
