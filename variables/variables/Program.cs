using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // Variable and data types
            string name = "Joshua";
            int age = 24;
            double height = 163;
            double weigth = 57.1;
            float num4 = 4.3f;
            bool isTrue = true;

            // A simple string concatenation
            Console.WriteLine("My name is " + name + ", I'm " + age + ", my height is " + height + "cm and my weigth " + weigth + ". A float number is " + num4);
            
            Console.ReadLine();

        }
    }
}
