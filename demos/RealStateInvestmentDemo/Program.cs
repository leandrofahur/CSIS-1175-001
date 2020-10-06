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
    }
}
