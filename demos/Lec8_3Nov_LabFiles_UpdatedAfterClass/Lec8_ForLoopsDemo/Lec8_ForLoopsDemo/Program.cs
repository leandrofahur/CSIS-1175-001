using System;
using static System.Console;

namespace Lec7_LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*WriteLine("Demo 1: Times table using for with increasing counter");
            for (int i = 1; i <= 12; i++)
            {
                WriteLine("Entered loop " + i);
                WriteLine(i + "\t" + i * 6); //\t means tab in console output
            }
            */
            WriteLine("Demo 2: Times table using for with decreasing order " +
                                "and concatenated string output");
            string outputStr = "";
            for (int i = 12; i > 0; i--)
            {
                WriteLine("Entered loop " + i);
                //WriteLine(i + "\t" + i * 6);
                outputStr = outputStr + i + "\t" + i * 6 + "\n"; //string concatenation
            }
            WriteLine(outputStr); //Displaying the combined string after loop is done

            
            WriteLine("Demo 3: Times table until product limit is reached");
            int prodLimit = 100;
            int product = 0;
            //in this demo condition contains product variable, which is indirectly related to i
            for (int i = 1; product < prodLimit;i++)
            {
                product = i * 6;
                string outputStr1 = i + "\t" + product; //note here it is not string concatenation
                WriteLine(outputStr1);
            }

           
        }
    }
}
