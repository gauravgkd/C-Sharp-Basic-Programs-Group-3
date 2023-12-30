using System;

namespace Assignment16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 2;

            Console.WriteLine("First 25 prime numbers:");

            do
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            } while (count < 25);

            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
