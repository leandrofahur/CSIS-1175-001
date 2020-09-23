using System; // this call is currently not being used
using static System.Console; // using directive to include System.Console static class, so that WriteLine() and ReadLine() may be used directly

namespace Lec3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // System is a namespace
            // Console is a class inside the namespace.
            //try
            //{
            //    int num = int.Parse("hello");
            //} catch(FormatException e)
            //{
            //    WriteLine(e.Message);
            //}

            WriteLine("Lecture 3, Demo 1: Fromatted output");
            Write("Enter the user name: ");
            string userName1 = ReadLine();

            Write("Enter the department: ");
            string dept = ReadLine();

            Write("Enter the faculty: ");
            string faculty = ReadLine();

            WriteLine("Faculty is: " + faculty);
            WriteLine("Faculty is {0}", faculty);
            WriteLine("{0}{1}", "Faculty is: ", faculty);

            //creating banner output with formatted output
            string asterikLine = new string('*', 64); //create a string by repeat * character 64 times and assign it to variable asterikLine
            WriteLine(asterikLine); //using the defined string variable asterikLine
            WriteLine("*{0, 20}: {1, -40}*", "Name", userName1); //WriteLine using formatted output
            WriteLine("*{0, 20}: {1, -40}*", "Dept", dept);
            WriteLine("*{0, 20}: {1, -40}*", "Faculty", faculty);
            WriteLine(asterikLine); //re-using asterikLine variable

            WriteLine("Demo 2: Working with integers (numeric)...");
            int grade1, grade2, grade3 = 0;
            
            Write("Enter grade 1: ");
            //Number entered by user from console through ReadLine() is always string, 
            //so needs to be converted to int before using in mathematical computations
            grade1 = int.Parse(ReadLine());


            Write("Enter grade 2: ");
            grade2 = int.Parse(ReadLine()); //getting grade2 input and parse it to convert it to integer and assign it to grade2 int

            Write("Enter grade 3: ");
            grade3 = int.Parse(ReadLine()); //getting grade3 input and parse it to convert it to integer and assign it to grade3 int
            
            double average = ((double)grade1 + grade2 + grade3) / 3; // you need to convert at least one to make the whole operation to be a double

            // Composed string format
            WriteLine(asterikLine);
            WriteLine("*{0, 20}: {1, -40}*", "Name", userName1);
            WriteLine("*{0, 20}: {1, -40}*", "Dept", dept);
            WriteLine("*{0, 20}: {1, -40}*", "Faculty", faculty);
            WriteLine("*{0, 20}: {1, -40:F5}*", "Avg Grade", average);
            WriteLine(asterikLine);

            WriteLine("Demo 3: Age incrementer - using prefix vs. postfix incrementer...");
            Write("Enter your age: ");
            int age = int.Parse(ReadLine());
            WriteLine("Lets try Prefix. Next year your age will be " + ++age); //notice incrementer and string concatenation, not using formatted output

            WriteLine("Lets try postfix increment");
            WriteLine("Value of age when postfx is used: {0,-5}",
                                                            age++); //formatted output
            WriteLine("Updated value of age is: {0}", age);
        }
    }
}
