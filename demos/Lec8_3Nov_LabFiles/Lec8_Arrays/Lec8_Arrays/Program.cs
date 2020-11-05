using System;
using System.Collections.Generic;
using static System.Console;
namespace Lec8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("Demo 1: Initializing and displaying an integer array");
            int[] numbersArray = new int[] { 78, 89, 77, 23, 98 };
            int numberOfElements = numbersArray.Length;
            for (int i = 0; i < numberOfElements; i++)
            {
                Write(numbersArray[i] + "\t");
            }
            WriteLine();
        }
    }
}
