using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if( age < 18 )
            {
                Console.WriteLine("You're too young");
            }
            else if ( age < 25 )
            {
                Console.WriteLine("You're teenager");
            }
            else
            {
                Console.WriteLine("You're old enough");
            }

            Console.ReadLine();

        }
    }
}
