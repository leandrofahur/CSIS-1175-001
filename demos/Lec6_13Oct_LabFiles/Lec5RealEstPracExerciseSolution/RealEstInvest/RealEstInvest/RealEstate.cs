using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstInvest
{
    class RealEstate
    {
        //Setting up auto-properties
        //Year, Address and Purchase are read-only properties
        public int Year
        {
            //define only getter because it is read-only
            //values of read-only are set in the constructor cannot be changed after object is created
            get;
        }

        public string Address
        {
            //read-only auto-property - no backing field, no setter
            get;
        }

        public double PurchasePrice
        {
            get;
        }
        public double IncomeFromRent
        {
            //read-write property, not read-only
            get; set;
        }
        public double MonthlyExpense
        {
            //read-write auto property
            get; set;
        }
        public double MonthlyEarnings
        {
            //read-only computed property
            //no set method
            get
            {
                return (IncomeFromRent - MonthlyExpense);
            }
        }

        public RealEstate(int year, string address, double purchasePrice)
        {
            Year = year; //value from the parameter is assigned to the property
            Address = address;
            PurchasePrice = purchasePrice;
            Console.WriteLine("Inside class saying hello"); //just a sample test WriteLine inside the constructor defined inside the class
        }
        //As an exercise write the default parameterless constructor 
        //and another version of constructor that sets the year, address, price, income, expense

        public RealEstate(int year, string address, double price, double income, double expense)
        {
            Year = year; //value from the parameter is assigned to the property
            Address = address;
            PurchasePrice = price;
            IncomeFromRent = income;
            MonthlyExpense = expense; //note that the value of parameters are always assigned to property
        }

       public override string ToString()
        {
            //this method must return a string
            string outputStr = "Street Address: " + Address + "\n"
                                + "Year Built: " + Year + "\n"
                                + "Purchase Price: " + PurchasePrice.ToString("C") + "\n"
                                + "Income From Rent: " + IncomeFromRent.ToString("C") + "\n"
                                + "Monthly Expense: " + MonthlyExpense.ToString("C") + "\n"
                                + "Monthly Earnings: " + MonthlyEarnings.ToString("C");
            return outputStr;
        }


    }
}
