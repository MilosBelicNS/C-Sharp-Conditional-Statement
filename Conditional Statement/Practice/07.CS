using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _07
    {
        //Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.

        public static void Main()
        {

            int h;
            Console.WriteLine("Accept the height of a person in centimeter and categorize them: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Input your height: ");
            h = Convert.ToInt32(Console.ReadLine());

            if (h < 150)
            {
             
                Console.WriteLine("This person is dwarf");
            }
            else if (h >= 150 && h < 165)
            {
               Console.WriteLine("This person is average height");

            }
            else if (h >= 165 && h <= 195)
            {
                Console.WriteLine("This person is taller");
            }
            else 

                Console.WriteLine("This person is abnormally tall");

            Console.ReadKey();
        }
    }
}
