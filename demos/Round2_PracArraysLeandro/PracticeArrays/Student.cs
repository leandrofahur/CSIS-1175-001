using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeArrays
{
    class Student
    {
        public string StudentName
        {
            get;
        }

        public string StudentId
        {
            get;
        }

        public double[] Grades
        {
            get;
        }

        public Student(string studentName, string studentId, double[] grades)
        {
            StudentName = studentName;
            StudentId = studentId;
            Grades = grades;
        }

        public void DisplayGrades()
        {
            foreach(double grade in Grades)
            {
                Console.WriteLine("Grade: " + grade);
            }
        }

        public void DisplayGradesAverage()
        {
            double avg = 0;
            for(int i = 0; i <= Grades.Length-1; i++)
            {
                avg = Grades[i];
            }

            avg = avg / (double)Grades.Length;
            Console.WriteLine("Grades average: " + avg);
        }

        public override string ToString()
        {
            return "I am inside the Student class!";
        }
    }
}
