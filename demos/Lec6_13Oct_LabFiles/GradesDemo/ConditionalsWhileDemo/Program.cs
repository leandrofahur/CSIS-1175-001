using System;
using static System.Console;

namespace ConditionalsWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             WriteLine("Demo 1: Use of if statement");
             Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
             char weatherForeCast = char.Parse(ReadLine()); //you may use int instead of char data type because options are numbers
             if (weatherForeCast == '1')
             {
                 WriteLine("Wear rain boots today");
             }
             if (weatherForeCast == '2')
             {
                 WriteLine("Wear snow boots today");
             }
             if (weatherForeCast == '3')
             {
                 WriteLine("Wear rain boots today");
             }

             WriteLine("\n\nDemo 2: Use of combined conditions");
             Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
             int weatherOption = int.Parse(ReadLine()); //just showing with int, similar to char data type
             if (weatherOption == 1 || weatherOption == 2 || weatherOption == 3)
             {
                 WriteLine("Yay! you entered valid input");
             }
             if (weatherForeCast != 1 && weatherForeCast != 2 && weatherForeCast != 3)
             {
                 WriteLine("Invalid input - option entered must be 1, 2 or 3 only");
             }
             WriteLine("\n\nDemo 3: Use of else if statement");
             Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
             weatherOption = int.Parse(ReadLine()); //already declared int weatherOption, re-using here

             if (weatherOption == 1)
             {
                 WriteLine("Please wear rain boots");
             } else if (weatherOption == 2)
             {
                 WriteLine("Please wear snow boots");
             } else if (weatherOption == 3)
             {
                 WriteLine("Please wear sandals");
             } else
             {
                 WriteLine("Invalid number, must be only 1, 2 or 3");
             } 

             WriteLine("\n\nDemo 4: Use of else if statement to check for grade with input validations");
             Write("Enter the grade: ");

             if(!int.TryParse(ReadLine(), out int grade1))
             {
                 WriteLine("Grade needs to be a valid integer between 0 and 100");
             } else if (grade1 < 0)
             {
                 WriteLine("Grade1 cannot be negative");
             } else if (grade1 > 100)
             {
                 WriteLine("Grade1 cannot be > 100");
             } else
             {
                 if (grade1 >= 80)
                 {
                     WriteLine("You got an A");
                 } else if (grade1 >= 70)
                 {
                     WriteLine("You got a B");
                 } else if (grade1 >= 60)
                 {
                     WriteLine("You got a C");
                 } else if (grade1 >= 50)
                 {
                     WriteLine("You got a P");
                 } else
                 {
                     WriteLine("It is a failing grade. Do better next time");
                 }
             } 

            WriteLine("\n\nDemo 5: Use of while statement to check for grade with input validations");
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
            } else if (myGrade >= 70)
            {
                WriteLine("You got a B");
            } else if (myGrade >= 60)
            {
                WriteLine("You got a C");
            } else if (myGrade >= 50)
            {
                WriteLine("You got a P");
            } else
            {
                WriteLine("It is a failing grade. Do better next time");
            }

        }
    }
}
