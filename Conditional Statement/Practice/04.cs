using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _04
    {
        //Write a C# Sharp program to find whether a given year is a leap year or not.

        public static void Main ()
        {
            int year;

            Console.WriteLine("Input year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("The {0} is a leap year.\n", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The {0} is a leap year.\n", year);
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("The {0} is a leap year.\n", year);
            }
            else
                Console.WriteLine("This isnt a leap year.");
                Console.ReadKey();
            


        }
    }
}
