using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _17
    {
        //Write a program in C# Sharp to accept a grade and display the equivalent description:
        //E Excellent
        //V Very Good
        //G   Good
        //A   Average
        //F   Fail

        public static void Main(string [] args)
        {
            string notes;
            
            Console.WriteLine("Izracunavanje racuna za struju: ");
            Console.WriteLine("-------------------------------------");

            Console.Write("Input the grade :");
           char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch(grade)
            {
                case 'E':
                 notes = "Excellent";
                 break;

                case 'V':
                    notes = "Very good";
                    break;

                case 'G':
                    notes = "Good";
                    break;

                case 'A':
                    notes = "Average";
                    break;

                case 'F':
                    notes = "Fail";
                    break;

                default:
                    notes = "Invalid Grade Found.";
                    break;

            }
            Console.Write("You have chosen  : {0}\n", notes);
            Console.ReadKey();


        }
    }
}
