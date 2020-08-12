using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _13
    {
        //Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.

        public static void Main()
        {
            Console.Write("Input side 1 of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("This is an Equilateral triangle");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else Console.WriteLine("This is an Scalene trinagle");
            Console.ReadKey();
        }
    }
}
