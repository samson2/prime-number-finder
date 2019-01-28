using System;

namespace prime_number_finder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a string and I will find prime numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int count;

            for(count = 0; count <= number; count ++)
            {
                if (count % 2 != 0 && count % 3 != 0 && count % 5 != 0 && count % 7 != 0)
                    Console.WriteLine(count);
            }


        }
    }
}
