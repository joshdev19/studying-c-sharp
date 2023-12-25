using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Are you single?");
            string ans = Console.ReadLine();

            if( ans == "yes" || ans == "YES" || ans == "Yes" || ans == "y" || ans == "Y")
            {
                
                Console.WriteLine("Great! I'm single too!");
            
            } else
            {

                Console.WriteLine("Oh, Well that's disappointing...");

            }

            Console.ReadLine();

        }
    }
}
