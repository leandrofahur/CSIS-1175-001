using System;
using System.Collections.Generic;
using static System.Console;
namespace Lec8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            WriteLine("Demo 1: Initializing and displaying an integer array");
            int[] numbersArray = new int[] { 78, 89, 77, 23, 98 };
            int numberOfElements = numbersArray.Length; //Length with upper case L denotes length of array or number of elements
            for (int i = 0; i < numberOfElements; i++)
            {
                Write(numbersArray[i] + "\t"); //writing the ith element in the array, i goes from 0 to Length-1
            }
            WriteLine();

            WriteLine("Demo 2: string array");
            string[] namesArray = { "John", "Amy", "William" };

             for (int i = 0; i < namesArray.Length; i++)
             {
                 WriteLine(namesArray[i]);
             } 

            DisplayArray(namesArray);
            DisplayArray(numbersArray); //can only be called if DisplayArray has a version (overloaded) that accepts int []
            */
            WriteLine("Demo 3: Working with double[], getting double values from user and processing it...");
            Write("Enter the number of grades: ");
            int numOfGrades;
            while(!int.TryParse(ReadLine(), out numOfGrades) || numOfGrades <= 0)
            {
                WriteLine("Number of grades must be > 0. Please re-enter number of grades: ");
            }

            double[] grades = new double[numOfGrades]; //declares double array of length given by numOfGrades
            //grades[0] = 78; //you may assign like this, but it is better to get the grade from user
            //grades[1] = 87;
            LoadGrades(grades); //this method call loads the values entered by the user into the grades array
            WriteLine("Displaying the grades back to the user...");
            foreach(double grade in grades)
            {
                Write(grade + "\t");
            }

            //Practice 1: exercise, work with int[], double[], string[] on your own
            //Prac 2: Write over-loaded DisplayArray(double[] anyDoubleArray) method to display each element of a double array
            //Prac 3: Write a method static double GetAvg(double[] anyArray) - computes the average of the double values and returns it
            //        Call this method to display the average grade based on grades entered
            //Prac 4: Write two methods to GetMinimumGrade(), and GetMaximumGrade() given any double array of grades
        
            //Additional option practice: using array of objects e.g., Product[] from your assignment
        }

        static void LoadGrades(double[] anyArray)
        {
            double grade;
            Write("Enter the grades by pressing enter after each grade...");
            for (int i = 0; i < anyArray.Length; i++)
            {
                while(!double.TryParse(ReadLine(), out grade) || grade < 0 || grade > 100)
                {
                    Write("Grade must be between 0 and 100. Please re-enter grade: ");
                }
                anyArray[i] = grade; //once valid grade is got, assign it to ith element of the array
            }
        }
        static void DisplayArray(int[] anyIntArray)
        {
            WriteLine("Entered overloaded DisplayArray with int array");
            foreach(int eachNum in anyIntArray)
            {
                Write(eachNum + "\t");
            }
        }

        static void DisplayArray(string[] anyArray)
        {
            WriteLine("Inside Display Array method....");
            for (int i = 0; i < anyArray.Length; i++)
            {
                WriteLine(anyArray[i]);
            }

            WriteLine();
            //for loops can be used to get/read the values of an array or
            //set the values of an array
            //But foreach loop is read-only, i.e., you cannot make changes to the array using 
            //foreach
            WriteLine("Display using foreach loop...");
            //keywords - foreach, in and datatype of each item
            //variables - each item (iterator), array variable
            string outputStr = "";
            foreach(string eachElement in anyArray)
            {
                outputStr = outputStr + eachElement + "\n";
                //eachElement = "hello"; //eachEement - iterator variable is read-only, so you cannot make changes to it
            }
            WriteLine(outputStr);
        }


    }
}
