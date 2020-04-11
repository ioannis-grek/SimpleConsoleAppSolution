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
            string color;
            Console.Write("Hello, what is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0} nice to meet you.", name);
            Console.Write("What is your favorite color? ");
            color = Console.ReadLine();
            if(color == "Red" || color == "Red")
            {
                Console.WriteLine("That's great, {0} is my favorite color too", color);
            }
            else
            {
                Console.WriteLine("Very nice, {0} is a nice color.", color);
            }
            Console.ReadKey();
        }
    }
}
