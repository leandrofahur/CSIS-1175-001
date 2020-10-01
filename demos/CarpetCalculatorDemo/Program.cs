using System;
using static System.Console;

namespace CarpetCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo: carpet calculator with methods...");
         
            double lengthInFeet = GetDimension("lenght");
            double widthInFeet = GetDimension("width");
            double areaSqYds = GetSqYds(lengthInFeet, widthInFeet);
            
            GetCarpetPrices("berber", "pile", out double priceOne, out double priceTwo);
            
            double costOne = GetCost(priceOne, areaSqYds);
            double costTwo = GetCost(priceTwo, areaSqYds);
            
            DisplayBanner(lengthInFeet, widthInFeet, priceOne, priceTwo, costOne, costTwo);
        }

        static double GetDimension(string carpetSide)
        {
            WriteLine("Enter the " + carpetSide + " in feet: ");
            int feet = int.Parse(ReadLine());
            WriteLine("Enter the " + carpetSide + " in inches: ");
            int inches = int.Parse(ReadLine());

            double totalDimension = feet + (double)inches / 12;

            return totalDimension;
        }

        static double GetSqYds(double lengthInFt, double widthInFt)
        {
            // Need to compute sq. ft by length * width
            double sqFt = lengthInFt * widthInFt;

            // Convert sq. ft to sq. yds -> 9sq. ft = 1 sq. yd
            double sqYds = sqFt / 9;

            return sqYds;
        }

        static void GetCarpetPrices(string carpetType1, string carpetType2, out double price1, out double price2)
        {
            // Use strings carpetType1 in message to user to get the cost of the carpet type
            // Use strings carpetType2 in message to user to get the cost of the carpet type
            // Assign values for both out parameters
            // return statement because method is of void type
            Write("Please, input the cost for the " + carpetType1 + ": ");
            price1 = double.Parse(ReadLine());
            Write("Please, input the cost for the " + carpetType2 + ": ");
            price2 = double.Parse(ReadLine());
        }

        static double GetCost(double carpetPricePerSqYd, double areaInPerSqYd)
        {
            // This takes the price per sq. yd value and area in sq. yds, and multiplies the two and return
            // the total price multiplying 
            return areaInPerSqYd * carpetPricePerSqYd;
        }

        static void DisplayBanner(double lengthInFt, double widthInFt, double berberPrice, double pilePrice, double berberCost, double pileCost)
        {
            // Using all these input vlues, you will create a banner using WriteLine()
            // note it is void method so return value
            //string asteriskStr = new string('*', 21);
            //WriteLine(asteriskStr);
            WriteLine("Length in ft.:{0:F0}", lengthInFt);
            WriteLine("Width in ft.:{0:F0}", widthInFt);
            WriteLine("Area in sq. yds.:{0:F2}", GetSqYds(lengthInFt,widthInFt));
            WriteLine("Berber price: {0:F2}", berberPrice);
            WriteLine("Pile price: {0:F2}", pilePrice);
            WriteLine("Berber cost: {0:F2}", berberCost);
            WriteLine("Pile cost: {0:F2}", pileCost);
        }
    }
}
