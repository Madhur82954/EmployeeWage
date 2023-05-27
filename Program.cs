using System;

namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        //public const int EMP_RATE_PER_HOUR = 20;
        //public const int NUM_OF_WORKING_DAYS = 2;
        //public const int MAX_HRS_PER_MONTH = 10;

        //UC8-Employee Wage for Multiple Companies
        public static int ComputeEmployeeWage(string company,int EMP_RATE_PER_HOUR,int MAX_HRS_PER_MONTH,int NUM_OF_WORKING_DAYS)
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;

            while (totalemphrs <= MAX_HRS_PER_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalemphrs += emphrs;
                Console.WriteLine("Days# " + totalworkingdays + " Emp Hrs :" + emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage = " + totalempwage);
            return totalempwage;
        }

        //UC-7 using class Methods 
        /*public static int EmployeeWage()
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;

            while (totalemphrs <= MAX_HRS_PER_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalemphrs += emphrs;
                Console.WriteLine("Days# " + totalworkingdays + " Emp Hrs :" + emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage = " + totalempwage);
            return totalempwage;
        }*/
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
            /* //UC2-EmployeeWage
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
            Console.WriteLine("Employee wage = " + empwage); */

            //UC3 - Part time employeewage 
            /* int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if(empcheck == IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if (empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empwage); */

            //UC4 - using Switch case

            /*int emphrs = 0;
            int empwage = 0;
            int totalempWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempWage += empwage;
                Console.WriteLine("Employee wage = " + empwage);
            }
            Console.WriteLine("Total Emp Wage = " + totalempWage); */

            // UC6 - emp month and hours calculation
            /*int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;

            while(totalemphrs<=MAX_HRS_PER_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                totalemphrs += emphrs;
                Console.WriteLine("Days# " + totalworkingdays + " Emp Hrs :"+ emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage = " + totalempwage);*/

            //UC7-EmployeeWage using class methods
            //EmployeeWage();

            //UC8- Employee Wage for Multiple Company using Class Methods 
            ComputeEmployeeWage("Dmart", 20, 2, 10);
            ComputeEmployeeWage("Reliance", 10, 4, 20);
        }
    }
}
