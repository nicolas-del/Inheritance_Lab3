using System;
using System.Collections.Generic;
using System.Linq;
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

        protected double starting_balance;  
        protected double current_balance;  
        protected double totalOfDepositsThisMonth; 
        protected double totalOfWithdrawalThisMonth; 
        protected double annualInterestRate; 
        protected double monthServiceCharge; 
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
            monthlyInterest = current_balance * monthlyInterestRate;
            current_balance += monthlyInterest;
        }

        public virtual string CloseAndReport()
        {
            double result; 
            result = current_balance - monthServiceCharge;
            CalculateInterest();
            numberOfWithdrawal = 0; 
            numberOfDeposits = 0;  
            monthServiceCharge = 0; 

            return "The balance at the beginning of the month was of " + starting_balance + ". Now it is of " + current_balance + " which minus the monthly service charge equals " + result + 
                   ".\nAnnual interest rate: " + annualInterestRate + 
                   "\nTotal deposits this month: " + totalOfDepositsThisMonth + 
                   "\nTotal of withdrawal this month: " + totalOfWithdrawalThisMonth;
        }

        public virtual void MakeDeposit(double amount)
        {
            starting_balance += amount;
            numberOfDeposits++;
        }

        public virtual void MakeWithdrawl(double amount)
        {
            starting_balance -= amount;
            numberOfWithdrawal++;
        }
    }
}
