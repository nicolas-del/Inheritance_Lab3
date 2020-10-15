using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
 
    abstract class Account : IAccount
    {   //ok
        protected enum Status
        {
            active, inactive 
        }
        //ok
        protected Status stat;
        protected double starting_balance;  
        protected double current_balance;  
        protected double totalOfDepositsThisMonth; 
        protected double totalOfWithdrawalThisMonth; 
        protected double annualInterestRate; 
        protected double monthServiceCharge = 15; 
        protected int numberOfDeposits;
        protected int numberOfWithdrawal;

        //ok
        public double Starting_Balance { get { return starting_balance; } }
        public double Current_Balance { get { return current_balance; } }

        public Account() { }

        //ok
        public Account(double sb, double annualRate) 
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        //ok
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
                   "\nService charges of the month: ");

            current_balance = starting_balance;
            starting_balance = 0;
            totalOfDepositsThisMonth = 0;
            totalOfWithdrawalThisMonth = 0;

            return "Your new current balance is of " + current_balance;
        }

        //ok
        public virtual void MakeDeposit(double amount)
        {
            double amnt;
            starting_balance += amount;
            amnt = amount;
            totalOfDepositsThisMonth += amnt;
            numberOfDeposits++;
        }

        //ok
        public virtual void MakeWithdraw(double amount)
        {
            double amnt;
            starting_balance -= amount;
            amnt = amount;
            totalOfWithdrawalThisMonth += amnt;
            numberOfWithdrawal++;
        }
    }
}
