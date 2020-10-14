using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Chequing_Account : Account
    {
        //ok
        public Chequing_Account(double sb, double annualRate) :base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }
        //ok
        public override string CloseAndReport() 
        {
            monthServiceCharge = numberOfWithdrawal * 0.10 + 5;
            return base.CloseAndReport();
        }

        //ok
        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }


        public override void MakeWithdraw(double amount)
        {
 
            if (amount > current_balance) 
            {
                monthServiceCharge -= 15;
                current_balance += 15;
 
                if (current_balance < 0)
                {
                   
                }
            }
            else
                base.MakeWithdraw(amount);
        }
    }
}
