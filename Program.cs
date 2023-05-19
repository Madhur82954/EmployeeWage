using System;

namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //UC1 - Employee present or absent
             int IS_FULL_TIME = 1;
             Random random = new Random();

             int empcheck = random.Next(0,2);

             if (empcheck == IS_FULL_TIME)
             {
                 Console.WriteLine("Employee is present");
             }
             else
             {
                 Console.WriteLine("Employee is absent");
             } */
            //UC2-EmployeeWage
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();

            int empcheck = random.Next(0,2);
            if(empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empwage);

        }
    }
}
