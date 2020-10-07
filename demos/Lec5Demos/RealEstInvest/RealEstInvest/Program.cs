using System;
using static System.Console;

namespace RealEstInvest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Lec5: Real Estate Investment Demo");
            GetPropertyInfo(out string address, out int year, out double purchasePrice);
            //now, you can create the RealEstate object
            RealEstate myRealEstate = new RealEstate(year, address, purchasePrice);
            myRealEstate.IncomeFromRent = 1965.99; //you can get this from user
            myRealEstate.MonthlyExpense = 789; //you can get this from user
            //myRealEstate.MonthlyEarnings = 501.00; //cannot set value of read-only property MonthlyEarnings

            WriteLine("The details of the real estate you entered are...");
            WriteLine(myRealEstate); //note you say WriteLine(object/instance); automatically calls ToString()

            //Call the GetIncomeAndExpense method with out arguments for income and rent
            //Set the IncomeFromRent and MonthlyExpense properties of myRealEstate object
            //WriteLine the object to see if the user values are displayed right
            GetIncomeAndExpense(out double incomeA, out double expenseA);
            WriteLine("The details of the real income and expenses you entered...");
            myRealEstate.IncomeFromRent = incomeA;
            myRealEstate.MonthlyExpense = expenseA;
            //WriteLine("{0}", myRealEstate.IncomeFromRent);
            //WriteLine("{0}", myRealEstate.MonthlyExpense);
            WriteLine(myRealEstate);
            //Write 5 parameter version of the constructor in the class - address, year, price, income, expense
            //Write a method in the Main program that gets user input for all these returns a string corresponding 
            //to the address, and sets out parameters for year, price, income and expense

            //Call this method to get all values from user and creates object using the 5-parameter constructor
            GetAllParameters(out string stAddress, out int yearBuilt, out double price, out double income, out double expense);
            RealEstate rE = new RealEstate(yearBuilt, stAddress, price, income, expense);
            Console.WriteLine(rE);
        }

        static void GetPropertyInfo(out string stAddress, out int yearBuilt, out double price)
        {
            Clear(); //clearing console window
            WriteLine("Enter the real state information here...");
            Write("Enter the street address: ");
            stAddress = ReadLine(); //gets street address from user and assigns it to the out parameter
            Write("Enter the year built: ");
            yearBuilt = int.Parse(ReadLine());
            Write("Enter the purchase price: ");
            price = double.Parse(ReadLine());
        }
        static void GetIncomeAndExpense(out double incomeFromRent, out double monthlyExpense)
        {
            //get income and expense from user after giving appropriate Write messages to the user
            //Clear();
            Write("Enter the income: ");
            incomeFromRent = double.Parse(ReadLine());
            Write("Enter the expense: ");
            monthlyExpense = double.Parse(ReadLine());
            //set the value of the out parameters
            //Note that syntax error is because out parameters are not set
        }

        //Create a method in the main program that returns the address (not void but string-return method)
        //and has four out parameters set for 
        //year, purchase price, income, expense
        //all input comes from the user
        static void GetAllParameters(out string stAddress, out int yearBuilt, out double price, out double income, out double expense)
        {
            WriteLine("Enter the real state information here...");
            Write("Enter the street address: ");
            stAddress = ReadLine(); //gets street address from user and assigns it to the out parameter
            Write("Enter the year built: ");
            yearBuilt = int.Parse(ReadLine());
            Write("Enter the purchase price: ");
            price = double.Parse(ReadLine());
            Write("Enter the income: ");
            income = double.Parse(ReadLine());
            Write("Enter the expense: ");
            expense = double.Parse(ReadLine());
        }

    }
}
