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
            /*  Serena Tindle
             * Deliverable #1- Math Challenge
             *  Septemeber 15, 2017 
             */


            //Declare variables.  User needs to input two integerr, var= result will be defined in the latter code.
            int Num1, Num2;

            //Ask user to enter digits, convert user input into integers.
            Console.WriteLine("Enter a number of that consists of three digits: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number that consits of three digits: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
           
            //Convert integer into a string again.
            string digitCount1 = Num1.ToString();
            string digitCount2 = Num2.ToString();
            
            //Begin the process of isolating the individual digits to confirm if they equate or not.
            if (digitCount1.Length == digitCount2.Length)
            {
                Console.WriteLine("Correct! Now let's find the sum of both numbers!"); //Screen will print this, based on user input.
            }

            else
            {
                Console.WriteLine("These number are not equal, try again!");//Screen will print this if improper number of digits are entered.
            }
            //Gathering the sum of each individual, from their respective place values.
            int digit1 = Convert.ToInt32(digitCount1[0]) + Convert.ToInt32(digitCount2[0]);
            int digit2 = Convert.ToInt32(digitCount1[1]) + Convert.ToInt32(digitCount2[1]);
            int digit3 = Convert.ToInt32(digitCount1[2]) + Convert.ToInt32(digitCount2[2]);

            if ((digit1 == digit2) && (digit2 == digit3) && (digit1 == digit3))
            {
                return true;
                Console.WriteLine("True"); //If input equates, output reads "True" 
            } 
               else
             {
                return false;
                Console.WriteLine("False"); //if input is not correct, ouptut reads "False"
            }
        }
    }
}