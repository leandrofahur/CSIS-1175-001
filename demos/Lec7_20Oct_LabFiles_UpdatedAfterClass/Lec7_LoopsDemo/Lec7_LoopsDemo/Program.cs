using System;
using static System.Console;

namespace Lec7_LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* WriteLine("\n\nDemo 1 (from previous lecture): Use of else if statement to check for grade with input validations");
            Write("Enter the grade: ");
           */
            /*if (!int.TryParse(ReadLine(), out int grade1)) //this is the same as if (int.TryParse(ReadLine(), out int grade1) == false)
            {
                //If there is a problem with the parse, then it enters the if block
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
                    //if grade >= 80, it will enter this if block
                    //Most importantly none of the other if conditions are checked
                    WriteLine("You got an A");
                }
                else if (grade1 >= 70)
                {
                    //It will come into this if block if grade < 80 and grade >= 70
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
                    //It enters this else block if grade >= 0 and grade < 50
                    WriteLine("It is a failing grade. Do better next time");
                }
            } 

            WriteLine("\n\nDemo 2: Use of while statement to check for grade with input validations");
            Write("Enter the grade: ");
            int myGrade;
            while (!int.TryParse(ReadLine(), out myGrade) || myGrade < 0 || myGrade > 100)
            {
                //Note the NOT operator in front of TryParse
                //Order of conditions matters - TryParse error has to be checked first

                //the while loop is entered if grade not  valid integer
                //or if grade is valid integer but is < 0
                //or if grade is valid integer and >= 0 but also > 100

                //the while loop is not enter if the grade is a valid integer between 0 and 100 inclusive
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
            }*/
            /*
            WriteLine("Demo 3: Times table using while with increasing counter");
            int count = 1; //this is a counter variable, typically int and has initial value; initial expression given here
            while (count <= 12) //conditional expression here - must return true or false, condition must be ( ) and no ; at the end
            {
                WriteLine("Entered loop " + count);
                WriteLine(count + "\t" + count * 6);
                count++; //Note here count is incremented by 1
                //count += 2; //increment count by 2
            }

            
            WriteLine("Demo 4: Times table using while with decreasing order " +
                                "and concatenated string output");
            string outputStr = ""; //output string accumulator starts out being empty
            int decCount = 12; //initial value of this variable is 12
            while (decCount > 0)
            {
                WriteLine("Entered loop " + decCount); //This WriteLine displays this string every time the loop is entered
                outputStr += decCount + "\t" + decCount * 6 + "\n"; //notice the += operatorstring accumulator to keep combining string output inside a loop
                decCount--; //Note here count is decremented by 1
            }
            WriteLine(outputStr); //Displaying the combined string after loop is done
            */

            /*WriteLine("Demo 5: Times table until product limit is reached");
            int numCount = 1; //keep track of the times value
            int product = numCount * 6; //keep track of the product, initially it will have 6

            while (product < 100)
            {
                string outputStr1 = numCount + "\t" + product; //note here it is not string concatenation/acculumator, just assigning to a string and displaying it
                WriteLine(outputStr1);
                numCount++; //note here numCount and product need to be updated
                product = numCount * 6;
            }*/

            
            WriteLine("Demo 6: Given Initial enrollment, cap in enrollment " +
                "and annual rate of increase, compute " +
                "yearly enrollment projections, repeat if user wants to enter more enrollment data");

            bool moreEnrollments = true; //I want to process at least one enrollment set, so initially this is set to true

            while (moreEnrollments)
            {
                //Keep entering the loop as long as there is more data to process

                //Process one set of data given initial Enrollment, annual rate of increase in enrollment and final enrollment numbers
                int initialEnrollment = 0, finalEnrollment; //an example of how to initialize and declare another variable at the same time

                double annualRate;
                Write("Enter the initial enrollment: ");
                while(!int.TryParse(ReadLine(), out initialEnrollment) 
                                    || initialEnrollment <= 0)
                {
                    Write("Please re-enter initial enrollment (must be positive integer): ");
                }

                Write("Enter the final enrollment: ");
                while(!int.TryParse(ReadLine(), out finalEnrollment)
                        || finalEnrollment <= initialEnrollment)
                {
                    Write("Please re-enter final enrollment (must be integer > initial enrollment): ");
                }

                Write("Enter the annual rate of increase in enrollment: ");
                while(!double.TryParse(ReadLine(), out annualRate)
                        || annualRate < 0 || annualRate > 10)
                {
                    Write("Please re-enter annual rate (must be double value between 0 and 10): ");
                }

                int currentYear = 1;
                int currentEnrollment = initialEnrollment; //initially current year enrollment is the same as initial enrollment

                while (currentEnrollment < finalEnrollment)
                {
                    WriteLine("Enrollment in year " + currentYear + " is " + currentEnrollment);
                    currentEnrollment = currentEnrollment + (int) Math.Round(annualRate * currentEnrollment / 100);
                    currentYear++;
                }

                //Ask the user if they want to process more data
                Write("Do you have more enrollments to process (yes/no): ");
                //Change moreEnrollments to false if user says no more data to enter

                string userInputMoreEnrollments = ReadLine(); //this string is either yes or no
                if (userInputMoreEnrollments == "no" || userInputMoreEnrollments == "No")
                {
                    moreEnrollments = false; //note false is keyword bool value all lower case no double quotes for false
                }
            }

            WriteLine("Good Bye");

           
        }
    }
}
