using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    
    abstract class Account : IAccount
    {
        protected enum Status
        {
            active, inactive 
        }
        
        protected Status stat;
        protected double starting_balance;  
        protected double current_balance;  
        protected double totalOfDepositsThisMonth; 
        protected double totalOfWithdrawalThisMonth; 
        protected double annualInterestRate; 
        protected double monthServiceCharge = 15; 
        protected int numberOfDeposits;
        protected int numberOfWithdrawal;

        
        public double Starting_Balance { get { return starting_balance; } }
        public double Current_Balance { get { return current_balance; } }

        public Account() { }

        
        public Account(double sb, double annualRate) 
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        
        public void CalculateInterest()
        {
            double monthlyInterest, monthlyInterestRate;

            monthlyInterestRate = annualInterestRate / 12;
            monthlyInterest = starting_balance * monthlyInterestRate;
            starting_balance += monthlyInterest;
        }


        public virtual string CloseAndReport()
        {
           
            starting_balance -= monthServiceCharge;
            CalculateInterest();
            numberOfWithdrawal = 0;
            numberOfDeposits = 0;
            monthServiceCharge = 0;

            Console.WriteLine("Starting balance: " + starting_balance +
                   "\nCurrent balance: " + current_balance +
                   "\nAnnual interest rate: " + annualInterestRate +
                   "\nTotal deposits this month: " + totalOfDepositsThisMonth +
                   "\nTotal of withdrawal this month: " + totalOfWithdrawalThisMonth +
                   "\nAccount status: " + stat +
                   "\nPercentage change: ");

            current_balance = starting_balance;
            starting_balance = 0;
            totalOfDepositsThisMonth = 0;
            totalOfWithdrawalThisMonth = 0;

            return "Your new current balance is of " + current_balance;
        }

        public virtual void MakeDeposit(double amount)
        {
            double amnt;
            starting_balance += amount;
            amnt = amount;
            totalOfDepositsThisMonth += amnt;
            numberOfDeposits++;
        }

        
        public virtual void MakeWithdraw(double amount)
        {
            double amnt;
            starting_balance -= amount;
            amnt = amount;
            totalOfWithdrawalThisMonth += amnt;
            numberOfWithdrawal++;
        }
    }

   

    static class ExtensionsMethod
    {

        public static double GetPercentageChange(this Account account)
        {
            double percentage;
            percentage = account.Starting_Balance / account.Current_Balance;
            switch (account.Current_Balance)
            {
                case 0:
                    return 0;
                default:
                    return percentage;
            }
        }

        public static void ToNAMoneyFormat(this Account account, bool roundup)
        {
            if (roundup)
            {
                Math.Round(account.Starting_Balance);
            }
        }
    }
}
