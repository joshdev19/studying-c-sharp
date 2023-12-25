using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("This number " + num + " will be skipped and the system will resumes its counting without this number " + num);
            Console.WriteLine("For loop is used and not equal operator");
            Console.ReadLine();

            for ( int c = 0; c <= 10; c++ )
            {
                if( c != num )
                {
                    Console.WriteLine(c);
                }
            }

            Console.ReadLine();

            Console.WriteLine("Similarly, for loop will be used and this time using continue statement");
            Console.ReadLine();

            for ( int c = 0; c <= 10; c++ )
            {

                // Continue statement will go back up untill it finishes its counting
                if (c == num) continue;

                Console.WriteLine(c);
                Console.WriteLine("Hello");

            }


            Console.ReadLine();

        }
    }
}
