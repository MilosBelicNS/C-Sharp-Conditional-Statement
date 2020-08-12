using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _15
    {
        //Write a C# Sharp program to check whether an alphabet is a vowel or consonant.

        public static void Main()
        {
            Console.WriteLine("Check whether the input alphabet is a vowel or not:   ");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Input char: ");
            char a = Convert.ToChar(Console.ReadLine());

            char[] c = { 'a', 'e', 'i', 'o', 'u' };

             for(int i = 0; i < c.Length; i++)
            {
                if(a == c[i])
                {
                    Console.WriteLine("The Alphabet is vowel.");
                }else 
                    Console.WriteLine("The Alphabet is consonant.");
                Console.ReadKey();
            }
        }
    }
}
