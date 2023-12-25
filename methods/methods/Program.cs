using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Write("This is the first method called Write");

            Console.WriteLine("This is the second method called Params with value of " + Params("Hello World"));

            Console.ReadLine();
        }

        static void Write( string value )
        {

            Console.WriteLine(value);

        }

        static string Params( string value )
        {

            return value;

        }

    }
}
