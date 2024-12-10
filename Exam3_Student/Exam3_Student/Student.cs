using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_Student
{
    internal class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentID { get; set; }

        public int ExamCount { get; set; }

        public double ExamWeight { get; set; }

        public List<double> ExamGrades { get; set; }

        public int HomeworkCount { get; set; }

        public double HomeworkWeight { get; set; }

        public List<double> HomeworkGrades { get; set; }

        public int QuizCount { get; set; }

        public double QuizWeight { get; set; }

        public List<double> QuizGrades { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            StudentID = 0;
            ExamCount = 4;
            ExamWeight = .4;
            ExamGrades = new List<double>();
            HomeworkCount = 5;
            HomeworkWeight = .3;
            HomeworkGrades = new List<double>();
            QuizCount = 5;
            QuizWeight = .3;
            QuizGrades = new List<double>();
        }

        public double GetAverage(List<double> list)
        {
            double avg = 0; 

            foreach (double grade in list)
            {
                avg += grade;
            }

            avg /= list.Count;

            return avg;
        }

        public double GetMax(List<double> list)
        {
            double max = 0;

            foreach (double grade in list)
            {
                if (grade > max)
                {
                    max = grade;
                }
            }

            return max;
        }

        public double GetMin(List<double> list)
        {
            double min = 100;

            foreach (double grade in list)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }

            return min;
        }

        public double GetFinalGrade()
        {
            double final = (GetAverage(ExamGrades) * ExamWeight) + (GetAverage(HomeworkGrades) * HomeworkWeight) + 
                (GetAverage(QuizGrades) * QuizWeight);

            return final;
        }

        public double GetGPA()
        {
            double GPA = 0;

            if (GetFinalGrade() >= 90)
            {
                GPA = 4;
            }
            else if (GetFinalGrade() >= 80)
            {
                GPA = 3;
            }
            else if (GetFinalGrade() >= 70)
            {
                GPA = 2;
            }
            else if (GetFinalGrade() >= 60)
            {
                GPA = 1;
            }

            return GPA;
        }

        public char GetLetterGrade()
        {
            char letter = 'F';

            if (GetGPA() == 4)
            {
                letter = 'A';
            }
            else if (GetGPA() == 3)
            {
                letter = 'B';
            }
            else if (GetGPA() == 2)
            {
                letter = 'C';
            }
            else if (GetGPA() == 1)
            {
                letter = 'D';
            }

            return letter;
        }
    }
}
