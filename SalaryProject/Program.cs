using System;

namespace SalaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // All the variables we will be working with.
            // For money we always use decimal to be precise.


            CalculateSalary();
          
        }


        static void CalculateSalary()
        {

         
            decimal netSalary;
            // Ask user for input gross salary.
            Console.Write("Please enter your gross salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());


            netSalary = salary;
            netSalary -= CalculateIncomeTax(salary);
            netSalary -= CalculateSocialContributions(salary);

            
            Console.WriteLine("Your net salary is: " + netSalary);
        }


        static decimal CalculateIncomeTax(decimal salary)
        {
            if (salary <= 1000m) return 0;
            salary -= 1000m;
            decimal incomeTax = 0.1m * salary; 
            Console.WriteLine("Income tax: " + incomeTax);
            return incomeTax;

        }

        static decimal CalculateSocialContributions(decimal salary)
        {
            if (salary <= 1000m) return 0;
            salary = Math.Min(salary, 3000m);
            decimal socialContributions = 0.15m * (salary - 1000m);
            Console.WriteLine("Social Contributions: " + socialContributions);
            return socialContributions;    

        }
    }
}
