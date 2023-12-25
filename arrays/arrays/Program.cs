using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[] {"Joshua", "John", "Lhea", "Joy"};

            Console.WriteLine("This is an array of names. Press the enter key to view the arrays");

            Console.ReadLine();

            foreach( string name in names )
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();


        }
    }
}
