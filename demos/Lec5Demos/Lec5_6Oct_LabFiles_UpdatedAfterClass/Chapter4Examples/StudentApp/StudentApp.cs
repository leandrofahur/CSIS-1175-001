using System;
using static System.Console;

namespace StudentApp
{
    //this is the same as the default Program.cs just renamed here
    //this class belongs to the same namespace as Student.cs
    class StudentApp
    {
        static void Main(string[] args)
        {
            Student firstStudentObject = new Student(); //Create a Student Object with name firstStudentObject
            firstStudentObject.StudentFirstName = AskForStudentName("First");
			firstStudentObject.StudentLastName = AskForStudentName("Last");
			firstStudentObject.StudentNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);

            Clear(); //Clears the console window
            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString());
            WriteLine(firstStudentObject); //automatically calls the ToString() method


            Student secondStudentObject = new Student("2345"); //called with student number parameter in the constructor
            secondStudentObject.Score1 = 95; //Assigning the value of 95 to property means the backign field is set to this value of 95
            secondStudentObject.Score2 = 62;
            secondStudentObject.Score3 = 87;
            WriteLine("\n\nSecond Student");
            //In this line below, I am getting the property StudentNumber of the secondStudentObject
            WriteLine("Student Number: " + secondStudentObject.StudentNumber +
                               "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());


            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Score1 = 95;
            thirdStudentObject.Score2 = 87;
            thirdStudentObject.Score3 = 72;
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);


            Student aStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87,"CS");
            WriteLine("\n\nLast Student");
            //here object.CalculateAverage() returns a double 
            //which is rounded to 1 decimal using F1 inside ToString()
            WriteLine("Student Name: " + aStudentObject.StudentFirstName +
                              " " + aStudentObject.StudentLastName +
                              "\nStudent Number: " + aStudentObject.StudentNumber +
                              "\nMajor: " + aStudentObject.Major +
                              "\nExam Score 1: " + aStudentObject.Score1 +
                              "\nExam Score 2: " + aStudentObject.Score2 +
                              "\nExam Score 3: " + aStudentObject.Score3 +
                              "\nExam Average: " + aStudentObject.CalculateAverage().ToString("F1")); 
            ReadKey();
        }

        static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Write("Enter a value for Score {0}: ", whichOne);
            inValue = ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }

        static string AskForStudentName(string whichOne)
        {
            string inValue;
            Write("Enter Student {0} Name: ", whichOne);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForMajor(string name)
        {
            string inValue;
            Write("Enter {0}\'s Major: ", name);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForStudentNumber()
        {
            string inValue;
            Write("Enter Student Number: ");
            inValue = ReadLine();
            return inValue;
        }
    }
}
