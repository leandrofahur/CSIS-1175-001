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
            WriteLine("The details of the real estate you entered so far are...");
            WriteLine(myRealEstate); //note you say WriteLine(object/instance); automatically calls ToString()
            
            //Update the income and expense for that object
            //using method call

            //Display the object after the update

        }

        static void GetPropertyInfo(out string stAddress, out int yearBuilt, out double price)
        {
            Clear(); //clearing console window
            WriteLine("Enter the real estate information here...");
            Write("Enter the street address: ");
            stAddress = ReadLine(); //gets street address from user and assigns it to the out parameter
            Write("Enter the year built: ");
            //Using TryParse instead of Parse for validating 
            //user input
        }

        //We will write a method to update the income and expense, object is passed as a paremeter
        //Note that when object is passed as parameter, changes to the property of the
        //object made inside the method, will be seen in the argument being passed from
        //other methods (e.g., main)
        
    }
}
