using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _02
    {
        //Write a C program to check whether a given number is even or odd.

        public static void Main()
        {
            int a;

            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

           


            if (a % 2 == 0)
                Console.WriteLine("{0} is even.\n", a);
            else
                Console.WriteLine("{0} is odd.\n", a);
            Console.ReadKey();


        }


    }
}
