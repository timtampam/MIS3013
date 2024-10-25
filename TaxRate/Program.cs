using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string name, stringSalary;
            double doubleSalary, fedTax, ficaTax;
            bool isDouble;

            // user input
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            // data validation
            do
            {
                Console.WriteLine("Please enter your salary: ");
                stringSalary = Console.ReadLine();
                isDouble = Double.TryParse(stringSalary, out doubleSalary);

                // not double or negative
                if (isDouble != true || doubleSalary < 0)
                {
                    Console.WriteLine("\nInvalid input, try again.");
                }
            } while (isDouble != true || doubleSalary < 0);

            // calculate taxes
            fedTax = CalculateFederalTax(doubleSalary);
            ficaTax = CalculateFICATax(doubleSalary);

            // output
            DisplayResults(name, doubleSalary, fedTax, ficaTax);

            Console.ReadKey(); // end
        }

        static double CalculateFederalTax(double salary)
        {
            double federalTax = 0;

            if (salary > 500000)
            {
                federalTax = 0.37;
            }
            else if (salary > 200000 && salary <= 500000)
            {
                federalTax = 0.35;
            }
            else if (salary > 157500 && salary <= 200000)
            {
                federalTax = 0.32;
            }
            else if (salary > 82500 && salary <= 157500)
            {
                federalTax = 0.24;
            }
            else if (salary > 38700 && salary <= 82500)
            {
                federalTax = 0.22;
            }
            else if (salary > 9525 && salary <= 38700)
            {
                federalTax = 0.12;
            }
            else // under 9525
            {
                federalTax = 0.10;
            }

            salary *= federalTax;

            return salary;
        }

        static double CalculateFICATax (double salary)
        {
            double ficaTax = 0.062;
            
            salary *= ficaTax;

            return salary;
        }

        static void DisplayResults(string name, double salary, double federalTax, double ficaTax)
        {
            Console.WriteLine("\nTaxes for " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Federal Tax: " + federalTax);
            Console.WriteLine("FICA Tax: " + ficaTax);
            Console.WriteLine("Net Salary: " + (salary - federalTax - ficaTax));
        }
    }
}
