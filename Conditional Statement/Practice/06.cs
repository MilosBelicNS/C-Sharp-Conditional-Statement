using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _06
    {
        //Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.


        public static void Main()
        {

            int m, n;
            Console.WriteLine("Input number");
            m = Convert.ToInt32(Console.ReadLine());

            if(m > 0)
            {
                n = 1;
                Console.WriteLine("The value of m = {0}", m);
                Console.WriteLine("The value of n = " + n);

            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine("The value of m = {0}", m);
                Console.WriteLine("The value of n = " + n);

            }
            else if (m < 0)
            {
                n = -1;
                Console.WriteLine("The value of m = {0}", m);
                Console.WriteLine("The value of n = " + n);

            }
            Console.ReadKey();
        }
    }
}
