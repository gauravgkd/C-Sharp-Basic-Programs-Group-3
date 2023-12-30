/*
 * Write a program to display ASCII characters in the range (0-255). 
 * Pause after displaying every 10 characters.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charPerLine = 10;
            int i = 0;
            while (i <= 255) 
            {
                for (int j = 0; j < charPerLine && i <= 255; j++) 
                {
                    char c = (char)i;
                    Console.Write(c);
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
