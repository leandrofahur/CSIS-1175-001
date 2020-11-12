using System;
using static System.Console;
using System.Collections.Generic;


namespace ListDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<double> GradesList = new List<double>();
            List<string> NamesList = new List<string>();

            Console.WriteLine("Hello World!");
            NamesList.Add("James");
            NamesList.Add("William");
            NamesList.Add("John");

            for (int i = 0; i < NamesList.Count; i++)
            {
                Write("Enter the grade for " + NamesList[i] + ": ");
                double grade2;
                while (!double.TryParse(ReadLine(), out grade2) || grade2 < 0 || grade2 > 100)
                {
                    Write("Grade for " + NamesList[i] + " must be between 0 and 100. Please re-enter grade: ");
                }
                GradesList.Add(grade2);
            }

            WriteLine();
            DisplayNamesAndGrades(NamesList, GradesList); 
        }

        private static void DisplayNamesAndGrades(List<string> namesList, List<double> gradesList)
        {
            WriteLine("Names given below: ");
            foreach(string name in namesList)
            {
                WriteLine(name);
            }

            WriteLine();
            WriteLine("Grades given below... ");
            foreach(double grade in gradesList)
            {
                WriteLine(grade.ToString("N1"));
            }
            WriteLine();
            WriteLine("Names and Grades for each student... ");
            for (int i = 0; i < namesList.Count; i++)
            {
                WriteLine(namesList[i] + " got " + gradesList[i].ToString("N1"));
            }
        }
    }
}
