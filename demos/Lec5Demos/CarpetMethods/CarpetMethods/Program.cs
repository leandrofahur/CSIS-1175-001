using System;
using static System.Console;

namespace CarpetMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem statement given in pg 116 for carpet calculator.
            //In this demo, we want to do carpet calculator with methods
            //Note there are syntax errors in this demo because
            //you need to complete the code inside the methods
            Console.WriteLine("Hello World!");
            WriteLine("Demo: Carpet calculator with methods....");
            double lengthInFeet = GetDimension("Length");
            double widthInFeet = GetDimension("Width"); //carpet side is passed as an argument
            double berberPrice, pilePrice; //two double variables for get the price (per sq. yd) of two carpet types
            GetCarpetPrices("Berber", "Pile", out berberPrice, out pilePrice);
            //Also, remember to call the methods you have defined to execute them
            //to complete your carpet calculator demo
            double AreaSqYds = GetSqYds(lengthInFeet, widthInFeet);
            double berberCost = GetCost(berberPrice, AreaSqYds);
            double pileCost = GetCost(pilePrice, AreaSqYds);
            DisplayBanner(lengthInFeet, widthInFeet, berberPrice, pilePrice, berberCost, pileCost);

        }
        static double GetDimension(string carpetSide) //carpetSide will get the string value of length or width
        {
            Write("Enter the " + carpetSide + " in feet: ");
            int feet = int.Parse(ReadLine()); //gets console input from user for the dimension in feet and converts to int
            Write("Enter the " + carpetSide + " in inches: ");
            int inches = int.Parse(ReadLine());
            double totalDimension = feet + (double)inches / 12;
            return totalDimension; //returns width or length in double feet value
        }
        static double GetSqYds(double lengthInFt, double widthInFt)
        {
            //Need to compute sq. ft by length*width
            //convert sq. ft to sq. yds -> 9 sq. ft = 1 sq. yd
            //return sq. yds
            double AreaSqYds = lengthInFt * widthInFt / 9;
            return AreaSqYds;
        }

        static void GetCarpetPrices(string carpetType1, string carpetType2,
                                        out double price1, out double price2)
        {
            //Use string carpetType1 in message to user to get the price for that carpet type
            //Use string carpetType2 in message to user to get the price for that carpet type
            //assign values for out parameters price1 and price 2
            //no return statement because method is void type
            Write("Enter Price for " + carpetType1 + ": ");
            price1 = double.Parse(ReadLine());
            Write("Enter Price for " + carpetType2 + ": ");
            price2 = double.Parse(ReadLine());
        }
        static double GetCost(double carpetPricePerSqYd, double areaInSqYds)
        {
            //This takes carpet price per sq. yd value and area in sq. yds, and multiplies the two
            //and returns the total cost given a price and area in sq yds
            //this is should return a double value
            double carpetCost = carpetPricePerSqYd * areaInSqYds;
            return carpetCost;
        }
        static void DisplayBanner(double lengthInFt, double widthInFt, 
                                    double berberPrice, double pilePrice,
                                       double berberCost, double pileCost) 
        {
            //using all these input values, you will create a banner using WriteLine()
            //note it is void method so return value
            WriteLine(new string('*', 54));
            WriteLine("*{0,25}: {1,-25:F2}*","Carpet Length",lengthInFt);
            WriteLine("*{0,25}: {1,-25:F2}*", "Carpet Width", widthInFt);
            WriteLine("*{0,25}: {1,-25:C}*", "Berber Price",berberPrice);
            WriteLine("*{0,25}: {1,-25:C}*", "Pile Price", pilePrice);
            WriteLine("*{0,25}: {1,-25:C}*", "Berber Cost", berberCost);
            WriteLine("*{0,25}: {1,-25:C}*", "Pile Cost", pileCost);
            WriteLine(new string('*', 54));
        }

    }
}
