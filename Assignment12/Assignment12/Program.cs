/*
 * Write a program to accept an Employee no. And department no. 
 * As numeric data and designation code as character data. 
 * Display the entered data with proper messages as below and 
 * refer the below table for entered data – */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee No : ");
            int empNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Department No : ");
            int deptNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Designation Code : ");
            char desgCode = char.Parse(Console.ReadLine());

            string deptName;
            string desgName;

            switch (deptNo)
            {
                case 10:
                    deptName = "Purchase";
                    break;
                case 20:
                    deptName = "Sales";
                    break;
                case 30:
                    deptName = "Production";
                    break;
                case 40:
                    deptName = "Marketing";
                    break;
                case 50:
                    deptName = "Accounts";
                    break;
                default:
                    deptName = "Unknown";
                    break;
            }

            switch (Char.ToUpper(desgCode))
            {
                case 'M':
                    desgName = "Manager";
                    break;
                case 'S':
                    desgName = "Supervisor";
                    break;
                case 'A':
                    desgName = "Analyst";
                    break;
                case 's':
                    desgName = "Sales Person";
                    break;   
                case 'a':
                    desgName = "Accountant";
                    break;
                default:
                    desgName = "Unknown";
                    break;
            }
            Console.WriteLine("Entered Data");
            Console.WriteLine($"Employee Number : {empNo}");
            Console.WriteLine($"Department Number : {deptNo}");
            Console.WriteLine($"Department Name : {deptName}");
            Console.WriteLine($"Designation Code : {desgCode}");
            Console.WriteLine($"Designation :{desgName}");
            Console.ReadKey();
        }
    }
}
