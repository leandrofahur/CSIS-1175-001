using System; // using directive is to existing classes and namespaces
using static System.Console; // import the Console Class


// The namespace is a collection of classes
namespace Lec2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.Write("Test...");
            //Console.WriteLine("Hello World!"); // Calling WriteLine method
            //WriteLine("This is line 2");
            //WriteLine("This is line 3");
            //WriteLine("********************************");

            //char c2c = 'l';
            //Console.WriteLine("**********************");
            //Console.WriteLine("*                    *");
            //Console.WriteLine("*    Name: Leandro   *");
            //Console.WriteLine("*    Dept: CSIS      *");
            //Console.WriteLine("*    Faculty: CBA    *");
            //Console.WriteLine("*                    *");
            //Console.WriteLine("**********************");
            //WriteLine(c2c);

            //// This is a pascal case variable:
            //int ThisIsAPascalCaseVariable = -60;
            //WriteLine(ThisIsAPascalCaseVariable);

            //// This is a camel case example:
            //int thisIsCamelCase = 60;
            //WriteLine(thisIsCamelCase);


            //Console.WriteLine("**********************");
            //Console.WriteLine("*                    *");
            //Console.WriteLine("*    Name: Leandro   *");
            //Console.WriteLine("*    Dept: CSIS      *");
            //Console.WriteLine("*    Faculty: CBA    *");
            //Console.WriteLine("*                    *");
            //Console.WriteLine("**********************");

            WriteLine(); // Insert blank line
            WriteLine("Lec2: Demo 2 - getting user input and using string variables");
            string userName = "";
            string userDepartment = "";
            string userFaculty = "";

            Write("Please insert the user name: ");
            userName = ReadLine();
            WriteLine("Your name is " + userName);

            WriteLine();
            Write("Please insert the department: ");
            userDepartment = ReadLine();
            userDepartment = userDepartment.ToUpper();
            WriteLine("Your department is " + userDepartment);

            WriteLine();
            Write("Please insert the faculty: ");
            userFaculty = ReadLine();
            userFaculty = userFaculty.ToUpper();
            WriteLine("Your faculty is "  + userFaculty);

            WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("*                    *");
            Console.WriteLine("*    Name: " + userName + "   *");
            Console.WriteLine("*    Dept: " + userDepartment + "      *");
            Console.WriteLine("*    Faculty: " + userFaculty + "    *");
            Console.WriteLine("*                    *");
            Console.WriteLine("**********************");


        }
    }
}


