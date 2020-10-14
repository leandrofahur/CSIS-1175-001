using System;
using System.Collections.Generic;
using System.Text;

namespace LeandroM_Assign1
{
    class Product
    {
        // read-only auto-property (getter):
        // this method return a string with the name of the product given by the constructor.
        public string ProductName
        {
            get;
        }
        
        // read-only auto-property (getter):
        // this method return a double with the price per unit of the product. The value is given by the constructor.
        public double PricePerUnit
        {
            get;
        }
        
        // read-write auto-property (getter & setter):
        // this rea-write property represents the quantity of units ordered by the user and can be changed during its life time.
        public int Quantity
        {
            get;
            set;
        }
        
        // read-only property (getter):
        // it is not an auto-property, it returns a computed value from a specific computation.
        // this method returns the value of the product before taxes. The value is givem by the Quantity * PricePerunit
        public double ProductTotalBeforeTax
        {
            get
            {
                // it is important to remember to cast the value of the int to avoid bugs!
                return ((double)Quantity * PricePerUnit);
            }
        }

        // read-only property (getter):
        // it is not an auto-property, it returns a computed value from a specific computation.
        // this method returns the value of the tax for the product. The value is givem by 0.08 * ProductTotalBeforeTax
        public double ProductTax
        {
            get
            {
                return (0.08 * ProductTotalBeforeTax);
            }
        }
       
        // read-only property (getter):
        // it is not an auto-property, it returns a computed value from a specific computation.
        // this method returns the value of the product with tax. The value is givem by ProductTotalBeforeTax + productTax
        public double ProductTotalAfterTax
        {
            get
            {
                return (ProductTotalBeforeTax + ProductTax);
            }
        }

        // this is a default constructor:
        // it will initialize the variables with a default value. E.g., string = "", int = 0 and so forth
        public Product()
        {

        }

        // this is the required constructor, it receives the ProductName and PricePerUnit
        public Product(string productName, double pricePerUnit)
        {
            ProductName = productName;
            PricePerUnit = pricePerUnit;
        }

        // override method ToString():
        public override string ToString()
        {
            // String format from this documentation: (the link provide on the assignment was broken)
            // https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1
            // .ToString("C") adds th currency
            string strFormated = String.Format("Product information:\n" 
                                               + "Name: {0}\n"
                                               + "Price per unit: {1:F2}\n"
                                               + "Quantity: {2}\n"
                                               + "Total before tax: {3:F2}\n"
                                               + "Tax: {4:F2}\n"
                                               + "Total after tax: {5:F2}\n"
                                               , ProductName
                                               , PricePerUnit.ToString("C")
                                               , Quantity
                                               , ProductTotalBeforeTax.ToString("C")
                                               , ProductTax.ToString("C")
                                               , ProductTotalAfterTax.ToString("C"));
            return strFormated;
        }
    }
}
