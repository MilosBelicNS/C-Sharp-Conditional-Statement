using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _05
    {
        //Write a C# Sharp program to read age of a candidate and determine whether it is eligible for casting his/her own vote.

        public static void Main()
        {
            int age;

            Console.WriteLine("Input first number: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >=18)
            {

                Console.WriteLine("Candidate is eligible for casting.");
            }else
                Console.WriteLine("Candidate isn't eligible for casting.");


        }
    }
}
