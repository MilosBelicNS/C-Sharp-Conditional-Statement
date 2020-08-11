using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _09
    {
        //Write a C program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

        public static void Main()
        {
            int x, y;

            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n");

            Console.Write("Input the value for X coordinate :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            y = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", x, y);
            else if (x < 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", x, y);
            else if (x < 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", x, y);
            else if (x > 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", x, y);
            else if (x == 0 && y == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", x, y);
            Console.ReadLine();
        }
    }
    }

