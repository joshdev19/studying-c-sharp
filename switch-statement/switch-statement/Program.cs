using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What day today is?");
            string ans = Console.ReadLine();

            switch(ans)
            {

                case "monday":
                    Console.WriteLine("Today is monday");
                    break;

                case "tuesday":
                    Console.WriteLine("Today is tuesday");
                    break;

                case "wenesday":
                    Console.WriteLine("Today is wenesday");
                    break;

                case "thusday":
                    Console.WriteLine("Today is thursday");
                    break;


                case "friday":
                    Console.WriteLine("Today is friday");
                    break;


                case "saturday":
                    Console.WriteLine("Today is saturday");
                    break;


                case "sunday":
                    Console.WriteLine("Today is sunday");
                    break;

                default: Console.WriteLine(" Invalid ");
                    break;

            }

            Console.ReadLine();

        }
    }
}
