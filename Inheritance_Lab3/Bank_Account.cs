using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Bank_Account : IAccount
    {

        private double starting_balance;
        private double current_balance;
        private int numberOfDeposits = 0;

        public double Starting_Balance { get { return starting_balance; } set { starting_balance = value; } }
        public double Current_Balance { get { return current_balance; } set { current_balance = value; } }

        public Bank_Account() { }

        public Bank_Account(double sb, double cb) 
        {
            starting_balance = sb;
            current_balance = cb;
        }



        public void CalculateInterest()
        {
            
        }

        public string CloseAndReport()
        {
            
        }

        public void MakeDeposit(double amount)
        {
            current_balance = starting_balance + amount;
            numberOfDeposits++;
        }

        public void MakeWithdrawl(double amount)
        {
            
        }
    }
}
