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
            monthServiceCharge = totalOfWithdrawalThisMonth * 0.10 + 5;
            return base.CloseAndReport();
        }


        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }


        public override void MakeWithdrawl(double amount)
        {
         
            
            if (current_balance < 0) 
            {
                monthServiceCharge -= 15;
                starting_balance += 15;
                current_balance = starting_balance;

                if (current_balance < 0)
                {
                    current_balance = starting_balance;
                }
            }
            else
                base.MakeWithdrawl(amount);
        }
    }
}
