using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _18
    {
        public static void Main ()
        {
            string day;

           

            Console.Write("Input the day number :");
            int daynum = Convert.ToInt32(Console.ReadLine());

            switch (daynum)
            {
                case 1:
                    day = "Monday";
                    break;

                case 2:
                    day = "Tuesday";
                    break;

                case 3:
                    day = "Wednesday";
                    break;

                case 4:
                    day = "Thursday";
                    break;

                case 5:
                    day = "Friday";
                    break;

                case 6:
                    day = "Saturday";
                    break;

                case 7:
                    day = "Sunday";
                    break;

                default:
                    day = "Invalid Grade Found.";
                    break;

            }
            Console.Write("You have chosen  : {0}\n", day);
            Console.ReadKey();
        }
    }
}
