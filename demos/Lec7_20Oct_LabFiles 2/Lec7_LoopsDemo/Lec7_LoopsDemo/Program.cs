using System;
using static System.Console;

namespace Lec7_LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\n\nDemo 1 (from previous lecture): Use of else if statement to check for grade with input validations");
            Write("Enter the grade: ");

            if (!int.TryParse(ReadLine(), out int grade1))
            {
                //Note the NOT (!) operator - will enter if only grade is not an integer
                WriteLine("Grade needs to be a valid integer between 0 and 100");
            }
            else if (grade1 < 0)
            {
                //Will enter this if grade1 is valid integer but < 0
                WriteLine("Grade1 cannot be negative");
            }
            else if (grade1 > 100)
            {
                //Will enter this if grade1 is valid integer, >= 0 but also > 100
                WriteLine("Grade1 cannot be > 100");
            }
            else
            {
                //Will enter else only if grade1 is valid integer, >=0 and <=100
                //Means it is valid grade1 data
                //Now we display the corresponding letter grade
                if (grade1 >= 80)
                {
                    WriteLine("You got an A");
                }
                else if (grade1 >= 70)
                {
                    WriteLine("You got a B");
                }
                else if (grade1 >= 60)
                {
                    WriteLine("You got a C");
                }
                else if (grade1 >= 50)
                {
                    WriteLine("You got a P");
                }
                else
                {
                    WriteLine("It is a failing grade. Do better next time");
                }
            }

            WriteLine("\n\nDemo 2: Use of while statement to check for grade with input validations");
            Write("Enter the grade: ");
            int myGrade;
            while (!int.TryParse(ReadLine(), out myGrade) || myGrade < 0 || myGrade > 100)
            {
                WriteLine("Grade needs to be a valid integer between 0 and 100");
                Write("Please re-enter the grade: ");
            }
            if (myGrade >= 80)
            {
                WriteLine("You got an A");
            }
            else if (myGrade >= 70)
            {
                WriteLine("You got a B");
            }
            else if (myGrade >= 60)
            {
                WriteLine("You got a C");
            }
            else if (myGrade >= 50)
            {
                WriteLine("You got a P");
            }
            else
            {
                WriteLine("It is a failing grade. Do better next time");
            }

            WriteLine("Demo 3: Times table using while with increasing counter");
            int count = 1;
            while (count <= 12)
            {
                WriteLine("Entered loop " + count);
                WriteLine(count + "\t" + count * 6);
                count++; //Note here count is incremented by 1
            }

            WriteLine("Demo 4: Times table using while with decreasing order " +
                                "and concatenated string output");
            string outputStr = "";
            int decCount = 12;
            while (decCount > 0)
            {
                WriteLine("Entered loop " + decCount);
                outputStr += decCount + "\t" + decCount * 6 + "\n"; //string accumulator to keep combining string output inside a loop
                decCount--; //Note here count is decremented by 1
            }
            WriteLine(outputStr); //Displaying the combined string after loop is done


            WriteLine("Demo 5: Times table until product limit is reached");
            int numCount = 1;
            int product = numCount * 6;

            while (product < 100)
            {
                string outputStr1 = numCount + "\t" + product; //note here it is not string concatenation
                WriteLine(outputStr1);
                numCount++;
                product = numCount * 6;
            }


            WriteLine("Demo 6: Given Initial enrollment, cap in enrollment " +
                "and annual rate of increase, compute " +
                "yearly enrollment projections, repeat if user wants to enter more enrollment data");

        }
    }
}
