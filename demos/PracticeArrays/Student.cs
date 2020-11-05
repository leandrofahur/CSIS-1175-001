using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeArrays
{
    class Student
    {
        public string StudentId
        {
            get;
        }

        public double[] Grades
        {
            get;
            private set; // (*) ask Priya
        }

        public void UploadGrades(double[] array)
        {
            Grades = new double[array.Length];
            for(int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = array[i];
            }
        }

        public void DisplayGrades()
        {
            Console.Write("Grades:");
            foreach (double grade in Grades)
            {
                Console.Write(" " + grade);
            }    
        }

        // (*) ask Priya Constructors
        public Student(string studentId)
        {
            StudentId = studentId;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
