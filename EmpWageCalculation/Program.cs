﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int IS_FULL_TIME = 1;               //Constant
            Random random = new Random();
            int empCheck = random.Next(0, 2);   // 0 or 1
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");   //1-->Emp is Present
            }
            else
            {
                Console.WriteLine("Employee is Absent");   //0 -->Emp Is Absent
            }
            Console.ReadLine();
        }
    }
}
