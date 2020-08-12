using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _11
    {
        //Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.

        public static void Main (string [] args)
        {
            Console.Write("Calculate the total, percentage and division to take marks of three subjects: \n ");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Input the Roll Number of the student : ");
            int roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Name of the Student : ");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input  the marks of Physics : ");
            int fiz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of  Chemistry : ");
            int hem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input  the marks of Computer Application : ");
            int comp = Convert.ToInt32(Console.ReadLine());

            int total = fiz + hem + comp;

            double percentage = total / 3.0;

            string div;

            if (percentage > 60)
            {
                div = "First";

            }
            else if (percentage < 60 && percentage > 48)
            {
                div = "Second";
            }
            else div = "Third";


            Console.WriteLine("Roll No: {0},\nName of Student: {1}", roll, name);
            Console.WriteLine("Marks in Physics : {0} \nMarks in Chemistry: {1} \nMarks in Computer App: {2} ", fiz, hem, comp);
            Console.WriteLine("Total marks: {0} \nPercentage is: {1},\nDivision: {2}", total, percentage, div);
            Console.ReadKey();

        }
    }
}
