using System;
using static System.Console;

namespace LeandroM_Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize the object with the product name and the price per unit
            Product p1 = new Product("Alcohol Gel", 12.00);
            Product p2 = new Product("Disposable Mask", 21.00);
            Product p3 = new Product("Wipes with alcohol", 3.00);

            // display some greeting to the client with the products information
            WriteLine("Welcome to iSneeze product ordering system!");
            WriteLine("You can place orders from any of ours three different products!");
            WriteLine();
            WriteLine("{0} with price per unit {1:C}", p1.ProductName, p1.PricePerUnit);
            WriteLine("{0} with price per unit {1:C}", p2.ProductName, p2.PricePerUnit);
            WriteLine("{0} with price per unit {1:C}", p3.ProductName, p3.PricePerUnit);
            WriteLine();

            // update the product quantity for all three products
            UpdateProductQty(p1);
            UpdateProductQty(p2);
            UpdateProductQty(p3);

            // take one out of three actions
            // it passes the product has a reference because it gives the possibility of changing them
            ChooseAction(p1, p2, p3);
        }

        // this method receive the product as a reference and change the quantity inside the object
        static void UpdateProductQty(Product product)
        {
            Write("Please, insert the number of {0} units: ", product.ProductName);
            product.Quantity = int.Parse(ReadLine());
        }

        // this method calls 2 other methods or exit the application using if-else
        static void ChooseAction(Product p1, Product p2, Product p3)
        {
            WriteLine();
            WriteLine("What would you like to do?");
            Write("Press 1 for View Cart, ");
            Write("Press 2 for Update Order, ");
            Write("Press 3 for Quitting the Application: ");
            // set the number choice for one that is not used for the if-else
            int numberChoice = -1;
            bool isNumber = int.TryParse(ReadLine(), out numberChoice);
            if(isNumber == true)
            {
                if (numberChoice == 1)
                {
                    //WriteLine();
                    // Clear the console window
                    //Clear();
                    WriteLine("Let's view what we have in the cart so far...");
                    ViewCart(p1, p2, p3);
                }
                else if (numberChoice == 2)
                {
                    WriteLine();
                    UpdateCart(p1, p2, p3);
                }
                else if (numberChoice == 3)
                {
                    // Clear the console window
                    Clear();
                    WriteLine("Thank you for placing an order with us. Good Bye!");
                    return;
                }
                else
                {
                    // if the user doesn't insert the number 1, 2 or 3 it will return to the choose action menu
                    WriteLine();
                    WriteLine("Please, insert one of the valid numbers!");
                    ChooseAction(p1, p2, p3);
                }
            }
            else
            {
                // if the user doesn't insert a number, it will return to the choose action menu
                WriteLine();
                WriteLine("Please, insert one of the valid numbers!");
                ChooseAction(p1, p2, p3);
            }
        }

        // this method calls other methods, and display the order details to the consumer
        static void ViewCart(Product p1, Product p2, Product p3)
        {
            WriteLine();
            GetCartTotalSummary(p1, p2, p3, out double totalBeforeDiscount, out double discountAmount);

            // call the ToString() overrided inside the class product for each and every product
            // creates a line of 40 '*' characteres
            string asteriskLine = new string('*', 40);
            // creates a line of 38 ' ' characteres
            string lineAsterisk = new string(' ', 38);
            // creates the line of 40 characteres with '*' at the beginning and the end, with ' ' between them
            string line = '*' + lineAsterisk + '*';
            WriteLine(asteriskLine);
            WriteLine(p1);
            WriteLine(line);
            WriteLine(p2);
            WriteLine(line);
            WriteLine(p3);
            WriteLine(asteriskLine);

            WriteLine();
            ChooseAction(p1, p2, p3);
        }

        // this method enable the user to update the quantity of a desired product 
        static void UpdateCart(Product p1, Product p2, Product p3)
        {
            WriteLine("What product would you like to update the quantity?");
            Write("Press 1 for {0}, Press 2 for {1}, Press 3 for {2}: ", p1.ProductName, p2.ProductName, p3.ProductName);
            // set the number choice for one that is not used for the if-else
            int numberChoice = -1;
            bool isNumber = int.TryParse(ReadLine(), out numberChoice);
            if (isNumber == true)
            {
                // each block store in a variable the old product qty., update the product qty. and then display the change for the user
                if (numberChoice == 1)
                {
                    WriteLine();
                    int oldQuantity = p1.Quantity;
                    UpdateProductQty(p1);
                    WriteLine("Quantity updated from {0} units to {1} units.", oldQuantity, p1.Quantity);
                    WriteLine();
                    ChooseAction(p1, p2, p3);

                }
                else if (numberChoice == 2)
                {
                    WriteLine();
                    int oldQuantity = p2.Quantity;
                    UpdateProductQty(p2);
                    WriteLine("Quantity updated from {0} units to {1} units.", oldQuantity, p2.Quantity);
                    WriteLine();
                    ChooseAction(p1, p2, p3);
                }
                else if (numberChoice == 3)
                {
                    WriteLine();
                    int oldQuantity = p3.Quantity;
                    UpdateProductQty(p3);
                    WriteLine("Quantity updated from {0} units to {1} units.", oldQuantity, p3.Quantity);
                    WriteLine();
                    ChooseAction(p1, p2, p3);
                }
                else
                {
                    // if the user doesn't insert the number 1, 2 or 3 it will return to the choose action menu
                    WriteLine();
                    WriteLine("Please, insert one of the valid numbers!");
                    ChooseAction(p1, p2, p3);
                }
            }
            else
            {
                // if the user doesn't insert a number, it will return to the choose action menu
                WriteLine();
                WriteLine("Please, insert one of the valid numbers!");
                ChooseAction(p1, p2, p3);
            }
        }

        // this method calculate discount (10% if purchase is over or equal to $100.00)
        static double GetCartTotalSummary(Product p1, Product p2, Product p3, out double totalBeforeDiscount, out double discountAmount)
        {
            double totalAfterDiscount = 0.00D;
            discountAmount = 0.00D;

            totalBeforeDiscount = p1.ProductTotalAfterTax + p2.ProductTotalAfterTax + p3.ProductTotalAfterTax;
            
            // check if the value is greater or equal to $100.00, apply discount and return the totalAfterDiscount variable 
            if(totalBeforeDiscount >= 100.00)
            {
                discountAmount = totalBeforeDiscount - 0.1*totalBeforeDiscount;
                totalAfterDiscount = totalBeforeDiscount - discountAmount;
                return totalAfterDiscount;
            }

            // if there is no discount, the return is simply the totalBeforeDiscount variable
            totalAfterDiscount = totalBeforeDiscount;
            return totalAfterDiscount;
        }
    }
}
