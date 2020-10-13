using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lab3
{
    class Savings_Account : Account
    {
        public Savings_Account(double sb, double annualRate) : base(sb, annualRate)
        {
            starting_balance = sb;
            annualInterestRate = annualRate;
        }

        public override string CloseAndReport()
        {
            if (totalOfWithdrawalThisMonth > 4)
                monthServiceCharge++;  
            return base.CloseAndReport();
        }

        public override void MakeDeposit(double amount) 
        {
            bool active = Convert.ToBoolean(Status.active);
            bool inactive = Convert.ToBoolean(Status.inactive);

            if (active)
            {
                base.MakeDeposit(amount);
            }
            else if (inactive && current_balance > 25)
            {
                inactive = active;
                base.MakeDeposit(amount);
            }
            else if (active && current_balance < 25)
                active = inactive;
        }

        public override void MakeWithdrawl(double amount)
        {
            bool active = Convert.ToBoolean(Status.active);

            if (active)
            {
                base.MakeWithdrawl(amount);
            }
           
        }
    }
}
