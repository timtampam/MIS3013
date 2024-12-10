using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string stringGrade;
            double doubleGrade;
            bool isDouble;

            // create student object
            Student S1 = new Student();

            // user input
            Console.WriteLine("Please enter a student's first name");
            S1.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter a student's last name");
            S1.LastName = Console.ReadLine();
            Console.WriteLine("Please enter a student's student ID in 4 digits (e.g. 1111)");
            S1.StudentID = Convert.ToInt32(Console.ReadLine());

            // input exam grades
            for (int i = 1; i < 5; i++)
            {
                do
                {
                    Console.WriteLine($"\nPlease input {S1.FirstName}'s exam #{i} grade >>");
                    stringGrade = Console.ReadLine();
                    isDouble = Double.TryParse(stringGrade, out doubleGrade);

                    if (isDouble == false) // invalid grade
                    {
                        Console.WriteLine($"{stringGrade} is not a valid grade. Please input again >>");
                    }
                    else if (doubleGrade < 0 || doubleGrade > 100) // grade not in range
                    {
                        Console.WriteLine($"{doubleGrade} is NOT between 0 and 100. Please input again >>");
                    }
                    else
                    {
                        S1.ExamGrades.Add(doubleGrade);
                    }
                } while (isDouble != true || doubleGrade < 0 || doubleGrade > 100);
            }

            // output exam grades evaluated
            Console.WriteLine($"\n{S1.FirstName}'s exam grades range between {S1.GetMin(S1.ExamGrades)} and " +
                $"{S1.GetMax(S1.ExamGrades)} with the average of {S1.GetAverage(S1.ExamGrades).ToString("N2")} " +
                $"\n(as {S1.ExamWeight.ToString("P2")} of the final grade)");

            // input homework grades
            for (int i = 1; i < 6; i++)
            {
                do
                {
                    Console.WriteLine($"\nPlease input {S1.FirstName}'s homework #{i} grade >>");
                    stringGrade = Console.ReadLine();
                    isDouble = Double.TryParse(stringGrade, out doubleGrade);

                    if (isDouble == false) // invalid grade
                    {
                        Console.WriteLine($"{stringGrade} is not a valid grade. Please input again >>");
                    }
                    else if (doubleGrade < 0 || doubleGrade > 100) // grade not in range
                    {
                        Console.WriteLine($"{doubleGrade} is NOT between 0 and 100. Please input again >>");
                    }
                    else
                    {
                        S1.HomeworkGrades.Add(doubleGrade);
                    }
                } while (isDouble != true || doubleGrade < 0 || doubleGrade > 100);
            }

            // output homework grades evaluated
            Console.WriteLine($"\n{S1.FirstName}'s homework grades range between {S1.GetMin(S1.HomeworkGrades)} and " +
                $"{S1.GetMax(S1.HomeworkGrades)} with the average of {S1.GetAverage(S1.HomeworkGrades).ToString("N2")} " +
                $"\n(as {S1.HomeworkWeight.ToString("P2")} of the final grade)");

            // input quiz grades
            for (int i = 1; i < 6; i++)
            {
                do
                {
                    Console.WriteLine($"\nPlease input {S1.FirstName}'s quiz #{i} grade >>");
                    stringGrade = Console.ReadLine();
                    isDouble = Double.TryParse(stringGrade, out doubleGrade);

                    if (isDouble == false) // invalid grade
                    {
                        Console.WriteLine($"{stringGrade} is not a valid grade. Please input again >>");
                    }
                    else if (doubleGrade < 0 || doubleGrade > 100) // grade not in range
                    {
                        Console.WriteLine($"{doubleGrade} is NOT between 0 and 100. Please input again >>");
                    }
                    else
                    {
                        S1.QuizGrades.Add(doubleGrade);
                    }
                } while (isDouble != true || doubleGrade < 0 || doubleGrade > 100);
            }

            // output homework grades evaluated
            Console.WriteLine($"\n{S1.FirstName}'s quiz grades range between {S1.GetMin(S1.QuizGrades)} and " +
                $"{S1.GetMax(S1.QuizGrades)} with the average of {S1.GetAverage(S1.QuizGrades).ToString("N2")} " +
                $"\n(as {S1.QuizWeight.ToString("P2")} of the final grade)");

            // output final grade
            Console.WriteLine($"\n{S1.FirstName} {S1.LastName} ({S1.StudentID})'s final grade is {S1.GetFinalGrade().ToString("N2")}");

            // output letter grade
            Console.WriteLine($"\n{S1.FirstName} {S1.LastName} ({S1.StudentID})'s letter grade is {S1.GetLetterGrade()} with a GPA of {S1.GetGPA()}");

            Console.ReadKey(); // end
        }

    }
}
