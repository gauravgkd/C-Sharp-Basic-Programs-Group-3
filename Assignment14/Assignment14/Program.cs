/*Write a program to accept a number from user and 
 * find its absolute value. Absolute always returns a positive value.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            double num = double.Parse(Console.ReadLine());

            double absoluteValue = GetAbsoluteValue(num);

            Console.WriteLine($"The Absolute Value of {num} is {absoluteValue}");

            Console.ReadKey();
        }
        static double GetAbsoluteValue(double num)
        {
            return (num < 0) ? -num : num;
        }
    }
}
