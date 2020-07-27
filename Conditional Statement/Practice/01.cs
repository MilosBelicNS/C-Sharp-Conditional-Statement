using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _01
    {

        //Write a C# Sharp program to accept two integers and check whether they are equal or not. 

        public static void Main()
        {
            int a, b;

            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());


            if (a == b)
                Console.WriteLine("{0} and {1} are equal.\n", a, b);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", a, b);
            Console.ReadKey();


        }

  
    }
}
