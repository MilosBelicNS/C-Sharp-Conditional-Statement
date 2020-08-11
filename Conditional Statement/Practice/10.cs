using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class Class1
    {
        //Write a C program to find the eligibility of admission for a professional course based on the following criteria:

        //Marks in Maths >=65
        //Marks in Phy >=55
        //Marks in Chem>=50
        //Total in all three subject >=180
        //or
        //Total in Math and Subjects >=140

        public static void Main(string [] args)
        {
           
                Console.WriteLine("Eligibility of admission for a professional course");
                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine("Input your marks: ");

                Console.WriteLine("Marks in Maths: ");
                int mat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Marks in Physics: ");
                int fiz = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Marks in Chemistry: ");
                int hem = Convert.ToInt32(Console.ReadLine());

                if ((mat >= 65 && fiz >= 55 && hem >= 50) || ((mat + fiz + hem) >= 180) || ((mat + fiz) >= 140))
                {
                    Console.WriteLine("The  candidate is eligible for admission \n");

                }
                else
                    Console.WriteLine("The  candidate is not eligible for admission");
            


            Console.ReadKey();

        }
        
    }
}
