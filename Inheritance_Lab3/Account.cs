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
        protected double starting_balance;  
        protected double current_balance;  
        protected double totalOfDepositsThisMonth; 
        protected double totalOfWithdrawalThisMonth; 
        protected double annualInterestRate; 
        protected double monthServiceCharge; 
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
            monthlyInterest = current_balance * monthlyInterestRate;
            current_balance += monthlyInterest;
        }


        public virtual string CloseAndReport()
        {
           
            current_balance -= monthServiceCharge;
            CalculateInterest();
            numberOfWithdrawal = 0;
            numberOfDeposits = 0;
            monthServiceCharge = 0;

            return "Starting balance: " + starting_balance +
                   "\nCurrent balance: " + current_balance +
                   "\nAnnual interest rate: " + annualInterestRate +
                   "\nTotal deposits this month: " + totalOfDepositsThisMonth +
                   "\nTotal of withdrawal this month: " + totalOfWithdrawalThisMonth +
                   "\nAccount status: " + Status.active +
                   "\nService charges of the month: " + monthServiceCharge;
        }

        //ok
        public virtual void MakeDeposit(double amount)
        {
            current_balance += amount;
            totalOfDepositsThisMonth += current_balance;
            numberOfDeposits++;
        }

        //ok
        public virtual void MakeWithdraw(double amount)
        {
            current_balance -= amount;
            totalOfWithdrawalThisMonth += current_balance;
            numberOfWithdrawal++;
        }
    }
}
