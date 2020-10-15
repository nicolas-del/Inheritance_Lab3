using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Chequing_Account : Account
    {
        
        public Chequing_Account(double sb, double annualRate) :base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }
        
        public override string CloseAndReport() 
        {
            monthServiceCharge = numberOfWithdrawal * 0.10 + 5;
            return base.CloseAndReport();
        }

        
        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }

        
        public override void MakeWithdraw(double amount)
        {
 
            if (amount > starting_balance) 
            {
                monthServiceCharge -= 15;
                starting_balance += 15;

                double rest = current_balance;

                if (starting_balance < 0)
                {
                    starting_balance -= rest;   
                }
            }
            else
                base.MakeWithdraw(amount);
        }

        
    }
}
