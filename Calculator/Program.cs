using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string calcType, repeat;
            double num1, num2, answer = 0;

            // call developer info
            DeveloperInfo("Anna", "MIS 3033", "Oct. 23, 2024");

            // user input
            do
            {
                // new calculation
                Console.WriteLine("\nWhat type of calculation do you want to do:");
                Console.WriteLine("add, subtract, multiply, or divide?");
                calcType = Console.ReadLine().ToLower();

                Console.WriteLine("\nEnter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // calculations
                if (calcType[0] == 'a')
                {
                    answer = Add(num1, num2);
                }
                else if (calcType[0] == 's')
                {
                    answer = Subtract(num1, num2);
                }
                else if (calcType[0] == 'm')
                {
                    answer = Multiply(num1, num2);
                }
                else if (calcType[0] == 'd')
                {
                    answer = Divide(num1, num2);
                }

                // output
                Console.WriteLine("\nAnswer: " + answer);

                // repeat prompt
                Console.WriteLine("\nDo you want to perform a new calculation, use the result from the previous calculation, or stop?");
                Console.WriteLine("Type 'n' for new calculation or 'p' for previous calculation or 's' to stop.");
                repeat = Console.ReadLine().ToLower();

                // previous calculation as value
                while (repeat[0] == 'p')
                {
                    num1 = answer;

                    Console.WriteLine("\nEnter another number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nWhat type of calculation do you want to do:");
                    Console.WriteLine("add, subtract, multiply, or divide?");
                    calcType = Console.ReadLine().ToLower();

                    // calculations
                    if (calcType[0] == 'a')
                    {
                        answer = Add(num1, num2);
                    }
                    else if (calcType[0] == 's')
                    {
                        answer = Subtract(num1, num2);
                    }
                    else if (calcType[0] == 'm')
                    {
                        answer = Multiply(num1, num2);
                    }
                    else if (calcType[0] == 'd')
                    {
                        answer = Divide(num1, num2);
                    }

                    // output
                    Console.WriteLine("\nAnswer: " + answer);

                    // repeat prompt
                    Console.WriteLine("\nDo you want to perform a new calculation, use the result from the previous calculation, or stop?");
                    Console.WriteLine("Type 'n' for new calculation or 'p' for previous calculation or 's' to stop.");
                    repeat = Console.ReadLine().ToLower();
                }
            } while (repeat[0] == 'n');

            Console.WriteLine("\nThank you for using my service.");

            Console.ReadKey(); // end
        }

        static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
        static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        static void DeveloperInfo(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($">> Note: {developerName} wrote this program for {className} on {dateOfWriting}.");
        }
    }
}
