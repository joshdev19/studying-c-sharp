using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_read_line_capture
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("How old are you " + name + "?");

            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Oh, so your age is " + age + " are you single?");

            string ans = Console.ReadLine();

            Console.WriteLine("I see, anyways, Your name is " + name + ", age is " + age + " and your answer if you're a single is " + ans);

            Console.WriteLine("Please press the enter key to close this terminal");

            Console.ReadLine();

        }
    }
}
