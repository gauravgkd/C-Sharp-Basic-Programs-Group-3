//Write a program to display whether
//a user entered number is a prime or no.
//Modify the same program to display
//first 25 prime numbers using while loop.
//A-lso write a same program using for and do-while loops.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number : ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(num);

            if (isPrime)
            {
                Console.WriteLine($"{num} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime Number.");
            }

            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

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