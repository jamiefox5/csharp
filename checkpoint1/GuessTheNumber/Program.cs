using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1, 11);

            Console.WriteLine(random);

            Console.WriteLine("Please enter a number between 1 and 10:");

            int number = int.Parse(Console.ReadLine());

            if (random == number)
            {
                Console.WriteLine("You guessed the correct number");
            }
            else
            {
                Console.WriteLine("You lost, so sad!");
            }

            Console.ReadLine();
        }
    }
}
