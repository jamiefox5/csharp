using System;

namespace checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;


            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count = count + 1;
                }

            }
            Console.WriteLine("There are " + count + " numbers divisible by 3 between 1 and 100");
            Console.ReadKey();
        }


    }
}
