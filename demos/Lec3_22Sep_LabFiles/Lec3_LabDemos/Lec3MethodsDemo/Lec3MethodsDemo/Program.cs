using System;
using static System.Console;

namespace Lec3MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Lecture 3, Method demo 1: void return type, no input method");
            SayHello();
            SayHello();
            SayHello();
            //WriteLine(helloMsg); //will not work because helloMsg declared inside the method

            WriteLine("Lecture 3, Method demo 2: void return type, two string inputs");
            SayHelloWithInputs("Hello", "Amanda");
            string anyMsg = "Welcome";
            string name = "Edward";
            SayHelloWithInputs(anyMsg, name);
            WriteLine(name);

            WriteLine("Lecture 3, Method demo 3: Value-returning, no input method");
            string customerName = GetNameFromUser();
            SayHelloWithInputs("Have a good day", customerName);
        }
        static void SayHello()
        {
            string helloMsg = "Hi, Priya!"; //variable is local to this method
            WriteLine(helloMsg);
        }
        static void SayHelloWithInputs(string msg,
                                        string userName)
        {
            WriteLine(msg + ", " + userName);
        }

        static string GetNameFromUser()
        {
            Write("Enter the user's name: ");
            string userName = ReadLine();
            return userName; //control leaves the method
            //WriteLine("This is the end"); unreachable code because it is after return statement
        }
    }
}