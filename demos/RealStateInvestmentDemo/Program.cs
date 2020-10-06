using System;
using System.Transactions;
using static System.Console;

namespace RealStateInvestmentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetProperty(out string address, out int year, out double purchasePrice);
            RealState realState = new RealState(year, address, purchasePrice);
            WriteLine("The details of the real state are: ");
            WriteLine(realState); // Calls toString() automatically

            // call GetIncomeAndExpense method with out arguments for ncome and rent
            // set the IncomeFromRent nd MontlyExpanse of realState object
            // WriteLine the object to see if the user values are displayed right

            // write 5 parameters version of the constructor in the class
            // write method in the Main that returns a string corresponding to the address, and sets out parameters for
            // year, price, income and expense
            // call this method to get all values from user and creates object using the 5-parameter constructor
        }

        static void GetProperty(out string stAddress, out int yearBuilt, out double price)
        {
            Clear();
            WriteLine("Enter the real state information here...");
            Write("Enter the street address: ");
            stAddress = ReadLine();
            Write("Enter the year built: ");
            yearBuilt = int.Parse(ReadLine());
            Write("Enter the purchase price: ");
            price = double.Parse(ReadLine());
        }

        static void GetIncomeAndExpense(out double incomeFromRent, out double montlyExpanse)
        {
            // get income and expanse from user after giving appropriate msgs to the user
            // set the value of the out parameters
        }
    }
}
