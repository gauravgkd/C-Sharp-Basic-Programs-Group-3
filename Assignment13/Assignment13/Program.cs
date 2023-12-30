/*Enter date in dd/mm/yy format.
 *Write a program to print 
 *total no. Of days in a month 
 *and month as character month.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date (dd) : ");
            int date = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Month (mm) : ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Year (yyyy) : ");
            int year = int.Parse(Console.ReadLine());

            int daysInMonth = GetDaysInMonth(month, year);

            if (daysInMonth > 0)
            {
                string monthName = GetMonthName(month);
                Console.WriteLine($"\n Total Number of Days in {monthName} {year} is : {daysInMonth}");
            }
            else
            {
                Console.WriteLine("Invalid Month or Year");
            }
            Console.ReadKey();
        }
        static int GetDaysInMonth(int month, int year) 
        {
            if (month >= 1 && month <= 12)
            {
                return DateTime.DaysInMonth(year, month);
            }
            else
            {
                return -1;
            }
        }
        static string GetMonthName(int month)
        {
            if (month >= 1 && month <= 12) 
            {
                return new DateTime(1,month,1).ToString("MMMM");
            }
            else
            {
                return "Invalid Month";
            }
        }
        

        }
    }

