using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class Program
    {
        public const int IS_FULL_TIME = 1; 
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);   // 0 or 1
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Full Time Employee Is Present");   //1-->Emp is present full time
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Half Time Employee Is Present");  //2--> Emp is Present Half Time
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");   //0 -->Emp Is Absent
                    empHrs = 0;
                    break;
            }

            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage : " +empWage);
            Console.ReadLine();
        }
    }
}
