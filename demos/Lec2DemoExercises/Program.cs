using System;
using System.Linq.Expressions;
using static System.Console;

namespace Lec2DemoExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ans = 0;
            //int v1 = 10;
            //int v2 = 19;
            //ans = v2 % v1++;
            //Console.WriteLine(ans);
            //int ans = 10;
            //int v1 = 5;
            //int v2 = 7;
            //int v3 = 18;
            //ans += v1 + 10*(v2/5) + v3/v2;
            //Console.WriteLine(ans);
            //Console.WriteLine(v2/5);
            //Console.WriteLine(v3/v2);
            Console.WriteLine("{0:f2}", 86);
            int _value1 = 0;
            Console.WriteLine(_value1);
            while (true)
            {
                // Simple menu for the user.
                Console.WriteLine("Choose the demo you want to play by typing the number: ");
                Console.WriteLine("[0] Exit the app");
                Console.WriteLine("[1] Display details as a banner from user input");
                Console.WriteLine("[2] Get input form user, execute some calculation and disply the results");
                int chooseDemo = int.Parse(Console.ReadLine());

                switch (chooseDemo)
                {
                    case 0:
                        Console.WriteLine("Closing app ...");
                        return;

                    case 1:
                        // Configuration and variables:
                        string asteriskLine = new string('*', 50);

                        Console.Write("Please, insert your name: ");
                        string name = Console.ReadLine();

                        Console.Write("Please, insert your course: ");
                        string course = Console.ReadLine();
                        course = course.ToUpper();

                        Console.Write("Please, insert the course code: ");
                        string courseCode = Console.ReadLine();

                        //Console.Write("Please, insert today's date: ");
                        //string date = Console.ReadLine();
                        DateTime date = new DateTime(2020, 09, 23);


                        // Constructing the banner:
                        Console.WriteLine(asteriskLine);
                        Console.WriteLine("* {0,6}: {1, -39}*", "Name", name);
                        Console.WriteLine("* {0,6}: {1, -39}*", "Course", course);
                        Console.WriteLine("* {0,6}: {1, -39}*", "Code", courseCode);
                        Console.WriteLine("* {0,6}: {1, -39}*", "Date", date.ToString("yyyy/MM/dd"));
                        Console.WriteLine(asteriskLine);
                        break;
                    
                    case 2:
                        // Configuration and variables:
                        Write("Enter the first grade: ");
                        string grade1String = ReadLine();
                        int grade1 = int.Parse(grade1String);

                        Write("Enter the second grade: ");
                        string grade2String = ReadLine();
                        int grade2 = int.Parse(grade2String);

                        Write("Enter the third grade: ");
                        string grade3String = ReadLine();
                        int grade3 = int.Parse(grade3String);

                        double average = ((double)grade1 + grade2 + grade3) / 3;

                        Write("Your grade average is: {0:F4}", average);

                        break;
                    
                    default:
                        WriteLine("Insert a valid number from the menu.");
                        break;
                }

                WriteLine();
            }
        }
    }
}
