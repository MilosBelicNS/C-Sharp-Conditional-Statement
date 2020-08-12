using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _12
    {
        //Write a C# Sharp program to read temperature in centigrade and display suitable message according to temperature.

        public static void Main(string [] args)
        {
            Console.WriteLine("Accept a temperature in centigrade and display a suitable message:");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.Write("Input  the temp : ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp < 0)
            {
                Console.WriteLine("Its freezing weather");
            }else if(temp <= 10 && temp >= 0)
            {
                Console.WriteLine("Its very cold weather");
            }
            else if (temp <= 20 && temp > 10)
            {
                Console.WriteLine("Its cold weather");
            }
            else if (temp <= 30 && temp > 20)
            {
                Console.WriteLine("Its normal weather");
            }
            else if (temp < 40 && temp > 30)
            {
                Console.WriteLine("Its hot weather");
            }else Console.WriteLine("Its very hot weather");

            Console.ReadKey();
        }

        
    }
}
