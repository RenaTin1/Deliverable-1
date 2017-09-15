using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddInts();
            Console.ReadKey();


        }
        public static bool AddInts()
        {
            //Declare variable.  User needs to input two integers
            int Num1, Num2;

            //Ask user to enter digits
            Console.WriteLine("Enter a number of that consists of three digits: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number that consits of three digits: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            string digitCount1 = Num1.ToString();
            string digitCount2 = Num2.ToString();

            if (digitCount1.Length == digitCount2.Length)
            {
                Console.WriteLine("Correct! Now let's find the sum of both numbers!");
            }

            else
            {
                Console.WriteLine("These number are not equal, try again!");
            }

            int digit1 = Convert.ToInt32(digitCount1[0]) + Convert.ToInt32(digitCount2[0]);
            int digit2 = Convert.ToInt32(digitCount1[1]) + Convert.ToInt32(digitCount2[1]);
            int digit3 = Convert.ToInt32(digitCount1[2]) + Convert.ToInt32(digitCount2[2]);

            if ((digit1 == digit2) && (digit2 == digit3) && (digit1 == digit3))
            {
                return true;
            } 
               else
             {
                return false;
            }
        }
    }
}