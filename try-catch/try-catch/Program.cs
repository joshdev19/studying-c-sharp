using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Try Catch
             * Try and catch if there's an error exception
             */

            try
            {

                Console.WriteLine("Numbers will be multiply");
                Console.ReadLine();

                Console.WriteLine("Enter a first number");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a second number");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double result = number1 * number2;

                Console.WriteLine(result);

            } 
            catch ( FormatException e)
            {

                Console.WriteLine("Number only.");

            }
            catch ( DivideByZeroException e )
            {

                Console.WriteLine("You cannot divide zero.");

            }
            catch (Exception e)
            {

                Console.WriteLine("An Error Occured" + e.Message);

            }
            finally
            {

                Console.WriteLine("Thank you for using our program!");

            }

            Console.ReadLine();

        }
    }
}
