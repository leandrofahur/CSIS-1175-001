using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

// This program is inspired on the suggested pratice Lec8_Arrays from Professor Priya
namespace PracticeArrays
{
    class Program
    {

        static void Main(string[] args)
        {
            Write("Please, enter the number of students: ");
            int numberOfStudents = 0;
            while (!int.TryParse(ReadLine(), out numberOfStudents) || numberOfStudents < 0)
            {
                Write("It should be an integer > 0! Please, re-enter the number of students: ");
            }

            Write("Please, enter the number of grades: ");
            int numberOfGrades = 0;
            while(!int.TryParse(ReadLine(), out numberOfGrades) || numberOfGrades < 0)
            {
                Write("It should be an integer > 0! Please, re-enter the number of grades: ");
            }

            ArrayList studentArrayList = new ArrayList();
            List<Student> studentList = new List<Student>();

            double[] grades = new double[numberOfGrades];

            // This loop will insert the grades for each student:
            for (int i = 0; i < numberOfStudents; i++)
            {

                WriteLine("Student number " + i);

                for (int j = 0; j < numberOfGrades; j++)
                {
                    Write("Please, enter " + numberOfGrades + " grades: ");
                    double grade;
                    while (!double.TryParse(ReadLine(), out grade) || grade < 0 || grade > 100)
                    {
                        Write("It should be a double >= 0 or <= 100! Please, re-enter the grade: ");
                    }

                    grades[j] = grade;
                }

                // Populate the ArrayList and the List<Student>
                studentArrayList.Add(new Student(i.ToString(), i.ToString(), grades));
                studentList.Add(new Student(i.ToString(), i.ToString(), grades));
            }
            
            foreach(Object obj in studentList)
            {
                WriteLine(obj);
            }
        }
    }
}
