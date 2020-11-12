using System;
using static System.Console;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] arrNumbers;
            int[] result;

            try
            {
                Write("Enter an integer number: ");
                number = int.Parse(ReadLine()); //what happens if it is not an integer
                arrNumbers = new int[] { 45, 56, 78, 89 };
                result = new int[4];

                //what happens when you have i <= arr.Length rather than i < arr.Length
                for (int i = 0; i <= arrNumbers.Length; i++)
                {
                    result[i] = arrNumbers[i] / number; //what happens if number entered is 0
                    Write("{0", result[i] + " "); //what happens where format string is incorrect
                }
            }
            catch(FormatException ex)
            {
                Write("\n");
                Write(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Write("\n");
                Write(ex.Message);
            }
            catch(Exception ex)
            {
                Write("\n");
                Write(ex.Message);
            }
            finally
            {
                Write("\n");
                Write("End of the application!");
            }
        }
    }
}
