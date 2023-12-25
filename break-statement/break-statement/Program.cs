using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * While loop and break statement
             * If we don't have a condition in the while and the data loops in definitely
             * Break statement is used when trying to guess what might will happen
             */

            int counter = 0;

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            // This will loop infinitely
            while( true )
            {

                /*
                 * The condition is inside of the while loop.
                 * if counter which is 0 will increment everytime by 1 since the condition set to true which is always run
                 * if counter reaches a certain number that's greater than the user's number, then the break statement will execute then escapes from while scope
                 */

                if (counter > num) break;
                Console.WriteLine(counter);
                counter++;

            }


            Console.ReadLine();

        }
    }
}
