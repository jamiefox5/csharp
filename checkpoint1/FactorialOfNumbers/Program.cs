using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i > 0; i--)
            {
                // 5 x 4 x 3 x 2 x 1
                factorial = factorial * i;
            }

            Console.WriteLine("The factorial of {0} is {1}", number, factorial);

            Console.ReadLine();
        }
    }
}
