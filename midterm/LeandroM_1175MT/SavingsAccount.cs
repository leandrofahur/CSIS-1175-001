using System;
using System.Collections.Generic;
using System.Text;

namespace LeandroM_1175MT
{
    class SavingsAccount
    {
        // read-only properties:
        public string AccountHolderName
        {
            get;
        }

        public char AccountType
        {
            get;
        }

        public double InitialDeposit
        {
            get;
        }

        // computed read-only propertie:
        public double InterestRate
        {
            get
            {
                if(AccountType == 'L')
                {
                    return 3.65;
                }
                else
                {
                    return 5.23;
                }
            }
        }

        public double YearlyCharge
        {
            get
            {
                if(AccountType == 'L')
                {
                    return 55.00;
                }
                else
                {
                    return 85.00;
                }
            }
        }
        // constructor:
        public SavingsAccount(string accountHolderName, char accountType, double initialDeposit)
        {
            AccountHolderName = accountHolderName;
            AccountType = accountType;
            InitialDeposit = initialDeposit;
        }

        public override string ToString()
        {
            string outputStr = "\nSavings Account Holder Details:" +
                               "\nSavings account holder name: " + AccountHolderName +
                               "\nSavings account type: " + AccountType +
                               "\nInitial deposit: " + InitialDeposit.ToString("C") +
                               "\nInterestRate: " + InterestRate.ToString("F2") +
                               "\nYearly charge: " + YearlyCharge.ToString("C");
            return outputStr;
        }
    }
}
