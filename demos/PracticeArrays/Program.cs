using System;
using System.Linq;
using static System.Console;

// This program is inspired on the suggested pratice Lec8_Arrays from Professor Priya
namespace PracticeArrays
{
    class Program
    {

        static void Main(string[] args)
        {
            Write("Enter the number of students: ");
            int numberOfStudents;
            while (!int.TryParse(ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
            {
                Write("Please, re-enter an integer > 0: ");
            }

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i <= numberOfStudents; i++)
            {
                Write("Enter the number of grades: ");
                int numberOfGrades;
                while (!int.TryParse(ReadLine(), out numberOfGrades) || numberOfGrades <= 0)
                {
                    Write("Please, re-enter an integer > 0: ");
                }

                double[] grades = new double[numberOfGrades];
                LoadGrades(grades);

                students[i] = new Student(i.ToString());
                students[i].UploadGrades(grades);
                students[i].DisplayGrades();
                Write("\n\n");
            }

            // Student student = new Student("1");
            // student.UploadGrades(grades);
            // student.DisplayGrades();
        }
        static void LoadGrades(double[] array)
        {
            Write("Enter a grade between 0.00 and 100.00 (included): ");
            double grade;
            for (int i = 0; i < array.Length; i++)
            {
                while(!double.TryParse(ReadLine(), out grade) || grade < 0 || grade > 100)
                {
                    Write("Please, re-enter an double >= 0 or <= 100: ");
                }
                array[i] = grade;
            }
        }
    }
}
