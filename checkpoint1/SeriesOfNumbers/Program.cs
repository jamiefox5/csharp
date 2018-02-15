using System;
using System.Linq;

namespace SeriesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int[] numbersArray = null;


            Console.WriteLine("Enter a series of numbers separated by comma");
            input = Console.ReadLine();

            try

            {
                numbersArray = Array.ConvertAll(input.Split(','), int.Parse);
                int maxValue = numbersArray.Max();
                Console.WriteLine("The highest number you enter is: " + maxValue);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Please enter only a number as digits and not as words, Please try again");
            }



            Console.ReadLine();

        }
    }


}

/*using System;
using System.Linq;

namespace SeriesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number = 0;


            Console.WriteLine("Enter a series of numbers separated by comma");
            input = Console.ReadLine();


            //change string into an integer
            int.TryParse(input, out number);





            Console.WriteLine("The highest number you enter is: " + input.Max());
            Console.ReadLine();

        }
    }


}
