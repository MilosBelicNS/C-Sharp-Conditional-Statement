using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _08
    {
        //Write a C program to find the largest of three numbers.

        public static void Main()
        {
            int h,j,k;
            Console.WriteLine("Find the largest of three numbers: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Input first num: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second num: ");
            j = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third num: ");
            k = Convert.ToInt32(Console.ReadLine());

            //if(h > j)
            //{
            //    if (h > k)
            //        Console.WriteLine("{0} is the largest number", h);
            //}else if(j > h)
            //{
            //    if(j > k)
            //        Console.WriteLine("{0} is the largest number", j);
            //}
            //else if (k > h)
            //{
            //    if (k > j)
            //        Console.WriteLine("{0} is the largest number", k);
            //}

            int[] a = { h, j, k };
            int theLargest = a.Max();
            Console.WriteLine("The largest number is {0} ", a.Max());

            Console.ReadKey();



        }
        
    }
}
