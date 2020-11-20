using System;
using static System.Console;

namespace LeandroM_1175MT
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Student Name, Student id: Leandro Machado, 300326045");
            WriteLine("\n\n");
            GetAccountHolderDetailsAndGoal(out string accountHolderName, out char accountType, out double initialDeposit, out double savingsGoal);
            SavingsAccount myAccount = new SavingsAccount(accountHolderName, accountType, initialDeposit);
            
            WriteLine("\n\n");
            WriteLine(myAccount); // calls the ToString() implicitly
            DisplayBalanceTable(myAccount, savingsGoal);
        }

        static void GetAccountHolderDetailsAndGoal(out string accountHolderName, out char accountType, out double initialDeposit, out double savingsGoal)
        {
            accountHolderName = "";
            accountType = 'U'; // Undefined
            initialDeposit = 0;
            savingsGoal = 0;

            Write("Enter the account holder's name: ");
            accountHolderName = ReadLine();
            while (accountHolderName == "")
            {
                WriteLine("Account holder's name cannot be blank");
                Write("Re-enter account holder's name: ");
                accountHolderName = ReadLine();
            }

            Write("Enter the account type (L-Low Interest, H-High Interest): ");
            while (!char.TryParse(ReadLine(), out accountType) || !accountType.Equals('L') && !accountType.Equals('H'))
            {
                Write("Account type mus be valid character H or L. Please Re-enter account type (L-Low Interest, H-High Interest): ");
            }

            Write("Enter the initial deposit: ");
            while (!double.TryParse(ReadLine(), out initialDeposit) || initialDeposit <= 0.00)
            {
                Write("Invalid initial deposit - should be valid double number > 0. Please re-enter the initial deposit: ");
            }

            Write("Enter the account balance goal: ");
            while (!double.TryParse(ReadLine(), out savingsGoal) || savingsGoal <= initialDeposit)
            {
                Write("Invalid account balance goal - should be valid double number > 0 and > initial deposit. Please re-enter the balance goal: ");
            }
        }
        static void DisplayBalanceTable(SavingsAccount myAccount, double goal)
        {
            double accountBalance = myAccount.InitialDeposit;
            int yearAcc = 1;
            while(accountBalance <= goal)
            {
                accountBalance += (accountBalance * myAccount.InterestRate / 100) - myAccount.YearlyCharge;
                Write("\nAccount balance at the end of year " + yearAcc + " will be " + accountBalance.ToString("C"));
                yearAcc++;
            }
        }
    }
}


