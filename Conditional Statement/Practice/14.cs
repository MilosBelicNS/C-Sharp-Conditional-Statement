using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _14
    {
        //Proveriti da li je trougao pravougli 
        public static void Main()
        {
            Console.WriteLine("Check whether a triangle can be formed by given value: ");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Input angle 1 of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());


            if ((a + b + c) == 180)
            {
                Console.WriteLine("The triangle is valid");

            }
            else Console.WriteLine("The triangle isnt valid");
            Console.ReadKey();
        }
    }
}
