using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1,2,3,4,5 };
            int counter = 0;

            Console.WriteLine("Loops");
            Console.ReadLine();

            Console.WriteLine("The first loop is for loop");
            Console.ReadLine();

            for (int i = 0; i < 10; i++ )
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            Console.WriteLine("The second loop is foreach ");
            Console.ReadLine();

            foreach ( int number in numbers )
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

            Console.WriteLine("The last loop is while loop");
            Console.ReadLine();

            Console.WriteLine("Enter a number and it will loop");
            int num = Convert.ToInt32(Console.ReadLine());

            while ( counter <= num )
            {
                Console.WriteLine(counter);
                counter++;
            }


            Console.ReadLine();

        }
    }
}
