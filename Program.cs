using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            Console.WriteLine("Enter a three digit number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second three digit number");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("The sum of the two nunbers is: " + result);
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
