using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int number = 0;

            string input = "";
            int number = 0;
            int total = 0;

            // if input doesnt equal "OK"
            while (input != "ok")
            {
                Console.WriteLine("Please enter a number, then press enter. When you are finished type 'ok' to quit");
                input = Console.ReadLine();
                // change number from string into integer 
                int.TryParse(input, out number);

                if (number > 0)
                {
                    //(+=) shorthand for (total = total + number)
                    total += number;
                    number = 0;
                }

            }

            Console.WriteLine("Total: " + total);
            Console.ReadLine();

        }
    }
}
