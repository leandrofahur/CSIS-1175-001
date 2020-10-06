using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace RealStateInvestmentDemo
{
    class RealState
    {
        // Read-only property
        public int Year
        {
            get;
        }

        // Read-only property
        public string Address
        {
            get;
        }

        // Read-only property
        public double PurchasePrice
        {
            get;
        }

        public double IncomeFromRent
        {
            get;
            set;
        }

        public double MontlyExpense
        {
            get;
            set;
        }

        // Read-only property
        public double MontlyEarnings
        {
            get
            {
                return (IncomeFromRent - MontlyExpense);
            }
        }

        public RealState(int year, string address, double purchasePrice)
        {
            Year = year;
            Address = address;
            PurchasePrice = purchasePrice;
        }

        // Write the default parameterless contructor and another version that sets
        // the year, address, price, income and expanse

        public override string ToString()
        {
            return "Street Address: " + Address + "\n"
                     + "Year built: " + Year + "\n"
                     + "Purchase price: " + PurchasePrice + "\n"
                     + "Income rent: " + IncomeFromRent + "\n"
                     + "Montly expense: " + MontlyExpense + "\n"
                     + "Montly earning: " + MontlyEarnings;
        }
    }
}
