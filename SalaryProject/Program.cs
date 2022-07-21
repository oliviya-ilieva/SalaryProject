using System;

namespace SalaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // All the variables we will be working with.
            // For money we always use decimal to be precise.
            decimal incomeTax = 0.1m;
            decimal socialContributions = 0.15m;
            decimal netSalary;
            decimal newSalary;
            decimal scSalary;

            // Ask user for input gross salary.
            Console.Write("Please enter your gross salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());


            if (salary <= 1000m)
            {
                netSalary = salary;
                Console.WriteLine("Your net salary is: " + netSalary);
            }
            else if (salary > 1000)
            {
                newSalary = salary - 1000;
                incomeTax = (incomeTax * newSalary);
                Console.WriteLine("Income tax: " + incomeTax);
                if (salary > 3000m)
                {
                    scSalary = 3000m;
                    socialContributions = socialContributions * (scSalary - 1000m);
                    Console.WriteLine("Social Contributions: " + socialContributions);
                } else
                {
                    socialContributions = socialContributions * (salary - 1000m);
                    Console.WriteLine("Social Contributions: " + socialContributions);
                }
                
                netSalary = salary - (socialContributions + incomeTax);
                Console.WriteLine("Your net salary is: " + netSalary);
            }
            
          
        }
    }
}
