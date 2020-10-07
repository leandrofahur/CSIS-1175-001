/* BonusCalculator.cs	Author:	Doyle	
 * Allows the user to input their
 * gross sales for the year. This value
 * is checked to determine whether
 * a bonus is in order.  
 **************************************/

using System;
using static System.Console;

namespace BonusCalculatorApp
{
    class BonusCalculatorApp
    {
        static void Main()
        {
            string inValue;
            decimal salesForYear;
            decimal bonusAmount = 0M;

            WriteLine("Do you get a bonus this year?");
            WriteLine();
            WriteLine("To determine if you are due one,");
            Write("enter your gross sales figure: ");
            inValue = ReadLine();
            salesForYear = Convert.ToDecimal(inValue);

            if (salesForYear > 500000.00M)
            {
                WriteLine();
                WriteLine("YES...you get a bonus!");
                bonusAmount = 1000.00M;
            }
            WriteLine("Bonus for the year: {0:C}",
                      bonusAmount);
            ReadKey();
        }
    }
}