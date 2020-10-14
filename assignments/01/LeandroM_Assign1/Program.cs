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

            // display some greeting to the client
            WriteLine("Welcome to iTchin product ordering system!");
            WriteLine("You can place orders from three different products!");
            WriteLine();

            // update the product quantity for all three products
            UpdateProductQty(p1);
            UpdateProductQty(p2);
            UpdateProductQty(p3);
            WriteLine();

            // take one out of three actions
            ChooseAction(p1, p2, p3);
        }

        // this method receive the product as a reference and change the quantity inside the object
        static void UpdateProductQty(Product product)
        {
            // Clear the console window
            // Clear();
            Write("Please, insert the number of {0} units: ", product.ProductName);
            product.Quantity = int.Parse(ReadLine());
        }

        // this method calls 2 other methods or exit the application using if-else
        static void ChooseAction(Product p1, Product p2, Product p3)
        {
            WriteLine("What would you like to do?");
            Write("Press 1 for View Cart,");
            Write("Press 2 for Update Order,");
            Write("Press 3 for Quitting the Application: ");
            int numberChoice = int.Parse(ReadLine());
            if (numberChoice == 1)
            {
                ViewCart(p1, p2, p3);
            }
            else if (numberChoice == 2)
            {
                WriteLine();
                UpdateCart(p1, p2, p3);
            }
            else if (numberChoice == 3)
            {
                Clear();
                WriteLine("Thank you for placing an order with us. Good Bye!");
                return;
            }
            else
            {
                // if the user doesn't insert the number 1, 2 or 3 it will return to the choose action menu
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
            string asteriskLine = new string('*', 40);
            string lineAsterisk = new string(' ', 38);
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
            int numberChoice = int.Parse(ReadLine());
        
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
            
            // check if the value is greater or equal to $100.00 and apply discount. 
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
