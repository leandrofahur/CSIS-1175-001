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
            GetIncomeAndExpense(out double incomeFromRent, out double monthlyExpense);

            //Set the IncomeFromRent and MonthlyExpense properties of myRealEstate object
            myRealEstate.IncomeFromRent = incomeFromRent;
            myRealEstate.MonthlyExpense = monthlyExpense;

            //WriteLine the object to see if the user values are displayed right
            WriteLine("After the user entered income and expense is updated, the details of the real estate investment is...");
            WriteLine(myRealEstate);

            //Write a method in the Main program that gets user input for all these returns a string corresponding 
            string newAddress = GetRealEstateDetails(out int newYear, out double price, out double income, out double expense);
            //to the address, and sets out parameters for year, price, income and expense
            //Call this method to get all values from user and creates object using the 5-parameter constructor

            RealEstate myRealEstate2 = new RealEstate(newYear, newAddress, price, income, expense);
            WriteLine("Details of the new real estate -object created with 5 parameters");
            WriteLine(myRealEstate2);
        }

        static void GetPropertyInfo(out string stAddress, out int yearBuilt, out double price)
        {
            Clear(); //clearing console window
            WriteLine("Enter the real estate information here...");
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
            //set the value of the out parameters
            //Note that syntax error is because out parameters are not set
            Write("Enter the income from rent: ");
            incomeFromRent = double.Parse(ReadLine());
            Write("Enter the monthly expense: ");
            monthlyExpense= double.Parse(ReadLine());
        }

        //Create a method in the main program that returns the address (not void but string-return method)
        //and has four out parameters set for 
        //year, purchase price, income, expense
        //all input comes from the user
        static string GetRealEstateDetails(out int year, out double price, out double income, out double expense)
        {
            WriteLine("Let us enter all the real estate information here...");
            Write("Enter the street address: ");
            string stAddress = ReadLine(); //gets street address from user and assigns it to a local variable, which will be returned in the end
            Write("Enter the year built: ");
            year = int.Parse(ReadLine());
            Write("Enter the purchase price: ");
            price = double.Parse(ReadLine());
            Write("Enter the income from rent: ");
            income = double.Parse(ReadLine());
            Write("Enter the monthly expense: ");
            expense = double.Parse(ReadLine());
            return stAddress; //note that return statement always at the end of the method code path

        }

    }
}
