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
            //if you declare the double[] array outside the numberOfStudents for loop,
            //then you are only creating one double[] grades array 
            //once for all students, rather it must be declared
            //inside the for loop, like I suggest below
            //That way, each time a student object needs
            //to be created, a new double[] grades array
            //is created.

            //double[] grades = new double[numberOfGrades]; 

            // This loop will insert the grades for each student:
            for (int i = 0; i < numberOfStudents; i++)
            {

                //you need to declare the double[] array inside the forloop
                //see explanation above
                //you can try commenting this and uncommenting the double[] you declared above
                //and see what happens
                double[] grades = new double[numberOfGrades];

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

            WriteLine(studentList.Count);
            //Here, in the foreach you had used the general Object class
            //which has very general methods available
            //Only when you use the Student data type
            //you will get methods available in that class
            //Suppose you have a mammal, you can only say it 
            //does not lay an egg, you cannot say it is will bark
            //Only if I tell you it is a dog, can you say it does 
            //not lay an egg and also barks
            //Similarly, any object belonging to the generic Object class
            //can have the method ToString() called
            //But only an object that belongs to the Student class
            //can have methods such as DisplayGrades(), DisplayAvergaeGrades()
            //called in it.
            foreach(Student obj in studentList)
            {
                // WriteLine(obj);
                obj.DisplayGrades(); //I just added this to see what grades were being stored in each student in the list just for testing
                obj.DisplayGradesAverage();
            }
        }
    }
}
